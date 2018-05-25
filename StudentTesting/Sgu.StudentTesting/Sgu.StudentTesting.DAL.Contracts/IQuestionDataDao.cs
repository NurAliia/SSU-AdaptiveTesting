using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgu.StudentTesting.DAL.Contracts
{
    public interface IQuestionDataDao
    {
        void InsertQuestionData(QuestionData questionData);

        IEnumerable<int> GetListIsRightAnswer();

        IEnumerable<QuestionData> GetQuestionData();

    }
}
