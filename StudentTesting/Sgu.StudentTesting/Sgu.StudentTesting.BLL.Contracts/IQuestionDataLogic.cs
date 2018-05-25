using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgu.StudentTesting.BLL.Contracts
{
    public interface IQuestionDataLogic
    {
        void InsertQuestionData(QuestionData questionData);

        IEnumerable<int> GetListIsRightAnswer();

        IEnumerable<QuestionData> GetQuestionData();

    }
}
