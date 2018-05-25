using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgu.StudentTesting.BLL.Contracts
{
    public interface ITestLogic
    {
        void AddTest(Test test);
        IEnumerable<Test> GetStudentsBySubjectTest(int subjectId);
        Question NewQuestion(int idUser);
        void Initialization(int idSubject);
        void DeleteQuestion(int idQuestion);
        IEnumerable<QuestionInTest> GetQuestionInTestBySubject(int IdTest);
        IEnumerable<Test> GetTestsStudent(int studentId);
        bool Test(int idUser);
        int GetResultForUser(User user);

    }
}
