using Common;
using Sgu.StudentTesting.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgu.StudentTesting.BLL
{
    public class QuestionDataLogic
    {
        private readonly IQuestionDataDao _questionDataDao;

        public QuestionDataLogic(IQuestionDataDao questionDataDao)
        {
            _questionDataDao = questionDataDao;
        }

        public void InsertQuestionData(QuestionData questionData)
        {
            _questionDataDao.InsertQuestionData(questionData);
        }

        public IEnumerable<int> GetListIsRightAnswer()
        {
            return _questionDataDao.GetListIsRightAnswer();
        }

        public IEnumerable<QuestionData> GetQuestionData()
        {
            return _questionDataDao.GetQuestionData();
        }

    }
}
