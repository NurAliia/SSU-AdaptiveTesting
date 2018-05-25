using AutoMapper;
using Common;
using Sgu.StudentTesting.BLL.Contracts;
using Sgu.StudentTesting.PL.ViewModel.Question;
using Sgu.StudentTesting.PL.ViewModel.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sgu.StudentTesting.PL.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestLogic _testLogic;
        private readonly IQuestionDataLogic _questionDataLogic;
        private QuestionData newQuestionData;
        private IUserLogic _userLogic;

        public TestController(ITestLogic testLogic, IQuestionDataLogic questionDataLogic, IUserLogic userLogic)
        {
            _testLogic = testLogic;
            _questionDataLogic = questionDataLogic;
            _userLogic = userLogic;
        }

        #region General

        // GET: Test
        public ActionResult Index(int id)
        {
            //Берем студента
            var a = Mapper.Map<IEnumerable<Test>, IEnumerable<TestVM>>(this._testLogic.GetTestsStudent(id));
            ViewData["idUser"] = id;
            return this.View(a);
        }
        
        public ActionResult SaveTest(TestVM test) //Принимает пройденный тест
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this._testLogic.AddTest(Mapper.Map<TestVM, Test>(test));
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex);
            }
            return View(test);
        }
        [HttpGet]
        public ActionResult StartTest(int idSubject, int id)
        {
            _testLogic.Initialization(idSubject);
            ViewData["idUser"] = id;
            Question question = _testLogic.NewQuestion(id);
            newQuestionData.IdQuestion = question.Id;
            newQuestionData.IdUser = id;
            newQuestionData.IdSubject = idSubject;
            newQuestionData.CorrectAnswer = int.Parse(question.CorrectAnswer);

            return View("NextQuestion", Mapper.Map<Question, QuestionDisplayVM>(question));
        }
        [HttpPost]
        public ActionResult StartTest(int answer)
        {
            var user = _userLogic.GetUserByEMail(System.Web.HttpContext.Current.User.Identity.Name.ToString()) ?? new Common.User();

            newQuestionData.AnswerQuestion = answer;
            newQuestionData.IsRightAnswer = (newQuestionData.AnswerQuestion ==newQuestionData.CorrectAnswer ) ? 1:0 ;
            _questionDataLogic.InsertQuestionData(newQuestionData);
            newQuestionData = null;
            _testLogic.DeleteQuestion(newQuestionData.IdQuestion);


            if (_testLogic.Test(user.Id))
            {
                return View("Result", new { result = _testLogic.GetResultForUser(user) });
            }
            Question question = _testLogic.NewQuestion(user.Id);
            
            newQuestionData.IdQuestion = question.Id;
            newQuestionData.IdUser = user.Id;
            newQuestionData.IdSubject = question.IdSubject;
            newQuestionData.CorrectAnswer = int.Parse(question.CorrectAnswer);
            return View("NextQuestion");
        }           
            
        public RedirectToRouteResult BackToStudents()
        {
            return RedirectToAction("Index","User");
        }
        public RedirectToRouteResult BackToSubject(int id)
        {
            return RedirectToAction("Index","Subject",new { id = id });
        }
        public ActionResult ListAnswers(int idTest, int idUser)
        {
            var a = Mapper.Map<IEnumerable<QuestionInTest>, IEnumerable<QuestionInTestDisplayVM>>(_testLogic.GetQuestionInTestBySubject(idTest));

            ViewData["idUser"]=idUser;
            return View(a);
        }
        public ActionResult Result(int result)
        {
            return View(result);
        }
        #endregion[/Method]
    }
}