using AdaptiveTesting.Entity;
using AdaptiveTesting.Entity.Enums;
using Common;
using Sgu.StudentTesting.BLL.Contracts;
using Sgu.StudentTesting.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgu.StudentTesting.BLL
{
    public class TestLogic : ITestLogic
    {
        #region [Fierlds]
        public const int MIN_QUESTIONS_FOR_THEME_CHANGE_COUNT = 5;
        public const int MIN_QUESTIONS_FOR_COMPLEXITY_CHANGE_COUNT = 2;
        private readonly ITestDao _testDao;
        private readonly ISubjectDao _subjectDao;
        private readonly IQuestionDataLogic _questionDataLogic;
        private readonly IQuestionLogic _questionLogic;
        public List<Question> TestList { get; set; }
        private INeuralNetworkBLL _neuralNetworkBLL;
        private IUserLogic _userLogic;


        #endregion [Fierlds]

        #region [Ctor]
        public TestLogic(ITestDao testDao, ISubjectDao subjectDao, IQuestionLogic questionLogic, IQuestionDataLogic questionDataDao, IUserLogic userLogic)
        {
            _testDao = testDao;
            _subjectDao = subjectDao;
            _questionLogic = questionLogic;
            _userLogic = userLogic;
            _neuralNetworkBLL = new NeuralNetworkBLL();
            _questionDataLogic = questionDataDao;
        }

        //public TestLogic()
        //{
        //    _testDao = new TestDao();
        //    _neuralNetworkBLL = new NeuralNetworkBLL();
        //    _subjectDao = new SubjectDao();
        //}

        public void Initialization(int idSubject)
        {
            TestList = new List<Question>(_subjectDao.GetQuestionBySubject(idSubject));
        }

        public void DeleteQuestion(int idQuestion)
        {
            int id;
            id = TestList.FindIndex(q => q.Id == idQuestion);
            TestList.RemoveAt(id);
        }

        public Question NewQuestion(int idUser)
        {
            User user = _userLogic.GetUserById(idUser);
                   
            return TestList.Find(q => q.Complexity == (int)user.CurrentComplexity);
            
        }

        public bool Test(int idUser)
        {
            User newUser = _userLogic.GetUserById(idUser);
            List<QuestionData> listQuestionData = _questionDataLogic.GetQuestionData().ToList();
            bool isThemeCompleted = false;
            List<int> listAnsweredQuestion = _questionDataLogic.GetListIsRightAnswer().ToList();
            NeuralNetworkResult newState = new NeuralNetworkResult();
            Complexity newComplexity = newUser.CurrentComplexity;
            double frequency = 0;

            if (listAnsweredQuestion.Count >= MIN_QUESTIONS_FOR_COMPLEXITY_CHANGE_COUNT)
            {
                if (!(listAnsweredQuestion.Count == 2 && listAnsweredQuestion[0] != listAnsweredQuestion[1]))
                {
                    if (listAnsweredQuestion[listAnsweredQuestion.Count - 1] != listAnsweredQuestion[listAnsweredQuestion.Count - 2])
                    {
                        newState = _neuralNetworkBLL.GetNewStateForNetworkThreeAnswers(newUser, listQuestionData, listAnsweredQuestion);
                        newComplexity = _neuralNetworkBLL.CalculateNewComplexity(newUser, newState.ComplexityState);
                        frequency = newState.Frequency;
                    }
                    else
                    {
                        newState = _neuralNetworkBLL.GetNewStateForNetworkTwoAnswers(newUser, listQuestionData, listAnsweredQuestion);
                        newComplexity = _neuralNetworkBLL.CalculateNewComplexity(newUser, newState.ComplexityState);
                        frequency = newState.Frequency;
                    }

                    if ((newUser.AnsweredQuestionsList.Count >= MIN_QUESTIONS_FOR_THEME_CHANGE_COUNT && newState.IsThemeCompleted))
                    {
                        isThemeCompleted = true;
                    }
                    else
                    {
                        newUser.CurrentComplexity = newComplexity;
                        newUser.ResultFrequency = frequency;
                    }
                }
            }

           // _userLogic.UpdateUser(newUser);

            if (isThemeCompleted)
            {
                int result = GetResultForUser(newUser);
                newUser.ResultTest = result;
                _testDao.CompleteTestForUser(newUser);
            }

            if (NewQuestion(newUser.Id) == null)
            {
                isThemeCompleted = true;
                int result = GetResultForUser(newUser);
                newUser.ResultTest = result;
                _testDao.CompleteTestForUser(newUser);
            }

            return isThemeCompleted;
        }    

        #endregion	[/Ctor]

        public void AddTest(Test test)
        {
            _testDao.AddTest(test);
        }
        public IEnumerable<Test> GetTestsStudent(int studentId)
        {
            return _testDao.GetTestsStudent(studentId).ToList();
        }
        public IEnumerable<Test> GetStudentsBySubjectTest(int subjectId)
        {
            return _testDao.GetStudentsBySubjectTest(subjectId);
        }
        public IEnumerable<QuestionInTest> GetQuestionInTestBySubject(int idTest)
        {
            return _testDao.GetQuestionInTestBySubject(idTest);
        }
        public int GetResultForUser(User user)
        {
            //var user = _userDao.GetUserById(id);

            ComplexityWithNone calculatedComplexity;
            int calculatedComplexityValue = (int)user.CurrentComplexity;
            if (user.ResultFrequency <= 0.5)
            {
                calculatedComplexityValue -= 1;
            }

            calculatedComplexity = (ComplexityWithNone)calculatedComplexityValue;

            if (calculatedComplexity == ComplexityWithNone.None)
            {
                return 2;
            }
            else if (calculatedComplexity == ComplexityWithNone.Light)
            {
                return 3;
            }
            else if (calculatedComplexity == ComplexityWithNone.Middle)
            {
                return 4;
            }
            return 5;
        }
    }
}
