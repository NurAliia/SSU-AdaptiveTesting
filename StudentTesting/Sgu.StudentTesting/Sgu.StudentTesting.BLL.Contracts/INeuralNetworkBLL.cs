using AdaptiveTesting.Entity;
using AdaptiveTesting.Entity.Enums;
using Common;
using System.Collections.Generic;

namespace Sgu.StudentTesting.BLL.Contracts
{
    public interface INeuralNetworkBLL
    {
        NeuralNetworkResult GetNewStateForNetworkTwoAnswers(User user, List<QuestionData> listQuestionData, List<int> listAnsweredQuestion);
        NeuralNetworkResult GetNewStateForNetworkThreeAnswers(User user, List<QuestionData> listQuestionData, List<int> listAnsweredQuestion);
        Complexity CalculateNewComplexity(User user, ComplexityState state);
        double GetFrequencyForUserByComplexity(List<QuestionData> listQuestionData, Complexity complexity, List<int> listAnsweredQuestion);
        void TrainNetworkTwoAnswers();
        void TrainNetworkThreeAnswers();
    }
}
