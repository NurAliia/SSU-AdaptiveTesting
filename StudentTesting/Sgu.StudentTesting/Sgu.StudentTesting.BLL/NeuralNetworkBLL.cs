using AdaptiveTesting.Entity;
using AdaptiveTesting.Entity.Enums;
using Common;
using Sgu.StudentTesting.BLL.Contracts;
using System;
using System.Collections.Generic;

namespace Sgu.StudentTesting.BLL
{
    public class NeuralNetworkBLL : INeuralNetworkBLL
	{
		public const int RIGHT_ANSWER = 1;
		public const int WRONG_ANSWER = 0;
		private NeuralNetworkForTwoAnswers _networkForTwoAnswers;
        private NeuralNetworkForThreeAnswers _networkForThreeAnswers;

		public NeuralNetworkBLL()
		{
			if (_networkForTwoAnswers == null)
			{
                _networkForTwoAnswers = new NeuralNetworkForTwoAnswers();
			}
            if (_networkForThreeAnswers == null)
            {
                _networkForThreeAnswers = new NeuralNetworkForThreeAnswers();
            }

        }
		public NeuralNetworkResult GetNewStateForNetworkTwoAnswers(User user, List<QuestionData> listQuestionData, List<int> listAnsweredQuestion)
		{
            double[] frequencies = new double[] {
            GetFrequencyForUserByComplexity(listQuestionData, Complexity.Light, listAnsweredQuestion),
            GetFrequencyForUserByComplexity(listQuestionData, Complexity.Middle, listAnsweredQuestion),
            GetFrequencyForUserByComplexity(listQuestionData, Complexity.Hard, listAnsweredQuestion)
            };
            int length = listAnsweredQuestion.Count;

			NeuralNetworkResult newState = _networkForTwoAnswers.Test(new int[] { listAnsweredQuestion[length - 1], listAnsweredQuestion[length - 2] }, frequencies);

			return newState;
		}

        public NeuralNetworkResult GetNewStateForNetworkThreeAnswers(User user, List<QuestionData> listQuestionData, List<int> listAnsweredQuestion)
        {
            double[] frequencies = new double[] {
            GetFrequencyForUserByComplexity(listQuestionData, Complexity.Light, listAnsweredQuestion),
            GetFrequencyForUserByComplexity(listQuestionData, Complexity.Middle, listAnsweredQuestion),
            GetFrequencyForUserByComplexity(listQuestionData, Complexity.Hard, listAnsweredQuestion)
            };
            int length = listAnsweredQuestion.Count;
            NeuralNetworkResult newState = _networkForThreeAnswers.Test(new int[] { listAnsweredQuestion[length - 1], listAnsweredQuestion[length - 2], listAnsweredQuestion[length - 3] }, frequencies);

            return newState;
        }

        public Complexity CalculateNewComplexity(User user, ComplexityState state)
		{
			int newComplexityValue = (int)user.CurrentComplexity;
			if (state == ComplexityState.Increase)
			{
				newComplexityValue = (int)user.CurrentComplexity + 1;
			}
			else if (state == ComplexityState.Lower)
			{
				newComplexityValue = (int)user.CurrentComplexity - 1;
			}

			Complexity newComplexity = user.CurrentComplexity;
			if (Enum.IsDefined(typeof(Complexity), newComplexityValue))
			{
				newComplexity = (Complexity)newComplexityValue;
			}

			return newComplexity;
		}

		public double GetFrequencyForUserByComplexity(List<QuestionData> listQuestionData, Complexity complexity, List<int> listAnsweredQuestion)
		{
			int rightAnswersCount = 0;

            int[] achievements = new int[listAnsweredQuestion.Count];

            for (int i = 0; i < listAnsweredQuestion.Count; i++)
            {
                achievements[i] = listAnsweredQuestion[i];
            }
           
            for (int i = 0; i < listAnsweredQuestion.Count; i++)
			{
				if (achievements[i] == RIGHT_ANSWER && listQuestionData[i].QuestionComplexity == (int)complexity)
				{
					rightAnswersCount++;
				}
			}

			return Math.Round(rightAnswersCount / (double)listAnsweredQuestion.Count, 1);
		}

		public void TrainNetworkTwoAnswers()
		{
			_networkForTwoAnswers.TrainNetwork();
		}

        public void TrainNetworkThreeAnswers()
        {
            _networkForThreeAnswers.TrainNetwork();
        }
    }
}