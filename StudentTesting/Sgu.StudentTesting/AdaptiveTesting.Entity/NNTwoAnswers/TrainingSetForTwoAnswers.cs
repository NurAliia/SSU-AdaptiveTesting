using AdaptiveTesting.Entity.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveTesting.Entity
{
	public static class TrainingSetForTwoAnswers
	{
		public const string NETWORK_TRAIN_DATA_FILEPATH = @"D:\TrainDataTwoAnswers.data";
		public static void CreateTrainingFile()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("149 5 3");

			sb.AppendLine("0 0 0 0 0");
			sb.AppendLine("-1 0 -1");

			sb.AppendLine("1 1 0 0 0.1");
			sb.AppendLine("1 0.1 1");
			sb.AppendLine("0 1 0 0 0.1");
			sb.AppendLine("0 0.1 1");
			sb.AppendLine("1 0 0 0 0.1");
			sb.AppendLine("0 0.1 1");
			sb.AppendLine("0 0 0 0 0.1");
			sb.AppendLine("-1 0.1 1");

			sb.AppendLine("1 1 0 0 0.2");
			sb.AppendLine("1 0.2 1");
			sb.AppendLine("0 1 0 0 0.2");
			sb.AppendLine("0 0.2 1");
			sb.AppendLine("1 0 0 0 0.2");
			sb.AppendLine("0 0.2 1");
			sb.AppendLine("0 0 0 0 0.2");
			sb.AppendLine("-1 0.2 1");

			sb.AppendLine("1 1 0 0 0.3");
			sb.AppendLine("1 0.3 1");
			sb.AppendLine("0 1 0 0 0.3");
			sb.AppendLine("0 0.3 1");
			sb.AppendLine("1 0 0 0 0.3");
			sb.AppendLine("0 0.3 1");
			sb.AppendLine("0 0 0 0 0.3");
			sb.AppendLine("-1 0.3 1");

			sb.AppendLine("1 1 0 0 0.4");
			sb.AppendLine("1 0.4 1");
			sb.AppendLine("0 1 0 0 0.4");
			sb.AppendLine("0 0.4 1");
			sb.AppendLine("1 0 0 0 0.4");
			sb.AppendLine("0 0.4 1");
			sb.AppendLine("0 0 0 0 0.4");
			sb.AppendLine("-1 0.4 1");

			sb.AppendLine("1 1 0 0 0.5");
			sb.AppendLine("1 0.5 1");
			sb.AppendLine("0 1 0 0 0.5");
			sb.AppendLine("0 0.5 1");
			sb.AppendLine("1 0 0 0 0.5");
			sb.AppendLine("0 0.5 1");
			sb.AppendLine("0 0 0 0 0.5");
			sb.AppendLine("-1 0.5 1");

			sb.AppendLine("1 1 0 0 0.6");
			sb.AppendLine("1 0.6 1");
			sb.AppendLine("0 1 0 0 0.6");
			sb.AppendLine("0 0.6 1");
			sb.AppendLine("1 0 0 0 0.6");
			sb.AppendLine("0 0.6 1");
			sb.AppendLine("0 0 0 0 0.6");
			sb.AppendLine("-1 0.6 1");

			sb.AppendLine("1 1 0 0 0.7");
			sb.AppendLine("1 0.7 1");
			sb.AppendLine("0 1 0 0 0.7");
			sb.AppendLine("0 0.7 1");
			sb.AppendLine("1 0 0 0 0.7");
			sb.AppendLine("0 0.7 1");
			sb.AppendLine("0 0 0 0 0.7");
			sb.AppendLine("-1 0.7 1");

			sb.AppendLine("1 1 0.1 0 0");
			sb.AppendLine("1 0.1 -1");
			sb.AppendLine("0 1 0.1 0 0");
			sb.AppendLine("0 0.1 -1");
			sb.AppendLine("1 0 0.1 0 0");
			sb.AppendLine("0 0.1 -1");
			sb.AppendLine("0 0 0.1 0 0");
			sb.AppendLine("-1 0.1 -1");

			sb.AppendLine("1 1 0.2 0 0");
			sb.AppendLine("1 0.2 -1");
			sb.AppendLine("0 1 0.2 0 0");
			sb.AppendLine("0 0.2 -1");
			sb.AppendLine("1 0 0.2 0 0");
			sb.AppendLine("0 0.2 -1");
			sb.AppendLine("0 0 0.2 0 0");
			sb.AppendLine("-1 0.2 -1");

			sb.AppendLine("1 1 0.3 0 0");
			sb.AppendLine("1 0.3 -1");
			sb.AppendLine("0 1 0.3 0 0");
			sb.AppendLine("0 0.3 -1");
			sb.AppendLine("1 0 0.3 0 0");
			sb.AppendLine("0 0.3 -1");
			sb.AppendLine("0 0 0.3 0 0");
			sb.AppendLine("-1 0.3 -1");

			sb.AppendLine("1 1 0.4 0 0");
			sb.AppendLine("1 0.4 -1");
			sb.AppendLine("0 1 0.4 0 0");
			sb.AppendLine("0 0.4 -1");
			sb.AppendLine("1 0 0.4 0 0");
			sb.AppendLine("0 0.4 -1");
			sb.AppendLine("0 0 0.4 0 0");
			sb.AppendLine("-1 0.4 -1");

			sb.AppendLine("1 1 0.5 0 0");
			sb.AppendLine("1 0.5 -1");
			sb.AppendLine("0 1 0.5 0 0");
			sb.AppendLine("0 0.5 -1");
			sb.AppendLine("1 0 0.5 0 0");
			sb.AppendLine("0 0.5 -1");
			sb.AppendLine("0 0 0.5 0 0");
			sb.AppendLine("-1 0.5 -1");

			sb.AppendLine("1 1 0.6 0 0");
			sb.AppendLine("1 0.6 -1");
			sb.AppendLine("0 1 0.6 0 0");
			sb.AppendLine("0 0.6 -1");
			sb.AppendLine("1 0 0.6 0 0");
			sb.AppendLine("0 0.6 -1");
			sb.AppendLine("0 0 0.6 0 0");
			sb.AppendLine("-1 0.6 -1");

			sb.AppendLine("1 1 0.7 0 0");
			sb.AppendLine("1 0.7 -1");
			sb.AppendLine("0 1 0.7 0 0");
			sb.AppendLine("0 0.7 -1");
			sb.AppendLine("1 0 0.7 0 0");
			sb.AppendLine("0 0.7 -1");
			sb.AppendLine("0 0 0.7 0 0");
			sb.AppendLine("-1 0.7 -1");

			sb.AppendLine("1 1 0 0.1 0");
			sb.AppendLine("1 0.1 0");
			sb.AppendLine("0 1 0 0.1 0");
			sb.AppendLine("0 0.1 0");
			sb.AppendLine("1 0 0 0.1 0");
			sb.AppendLine("0 0.1 0");
			sb.AppendLine("0 0 0 0.1 0");
			sb.AppendLine("-1 0.1 0");

			sb.AppendLine("1 1 0 0.2 0");
			sb.AppendLine("1 0.2 0");
			sb.AppendLine("0 1 0 0.2 0");
			sb.AppendLine("0 0.2 0");
			sb.AppendLine("1 0 0 0.2 0");
			sb.AppendLine("0 0.2 0");
			sb.AppendLine("0 0 0 0.2 0");
			sb.AppendLine("-1 0.2 0");

			sb.AppendLine("1 1 0 0.3 0");
			sb.AppendLine("1 0.3 0");
			sb.AppendLine("0 1 0 0.3 0");
			sb.AppendLine("0 0.3 0");
			sb.AppendLine("1 0 0 0.3 0");
			sb.AppendLine("0 0.3 0");
			sb.AppendLine("0 0 0 0.3 0");
			sb.AppendLine("-1 0.3 0");

			sb.AppendLine("1 1 0 0.4 0");
			sb.AppendLine("1 0.4 0");
			sb.AppendLine("0 1 0 0.4 0");
			sb.AppendLine("0 0.4 0");
			sb.AppendLine("1 0 0 0.4 0");
			sb.AppendLine("0 0.4 0");
			sb.AppendLine("0 0 0 0.4 0");
			sb.AppendLine("-1 0.4 0");

			sb.AppendLine("1 1 0 0.5 0");
			sb.AppendLine("1 0.5 0");
			sb.AppendLine("0 1 0 0.5 0");
			sb.AppendLine("0 0.5 0");
			sb.AppendLine("1 0 0 0.5 0");
			sb.AppendLine("0 0.5 0");
			sb.AppendLine("0 0 0 0.5 0");
			sb.AppendLine("-1 0.5 0");

			sb.AppendLine("1 1 0 0.6 0");
			sb.AppendLine("1 0.6 0");
			sb.AppendLine("0 1 0 0.6 0");
			sb.AppendLine("0 0.6 0");
			sb.AppendLine("1 0 0 0.6 0");
			sb.AppendLine("0 0.6 0");
			sb.AppendLine("0 0 0 0.6 0");
			sb.AppendLine("-1 0.6 0");

			sb.AppendLine("1 1 0 0.7 0");
			sb.AppendLine("1 0.7 0");
			sb.AppendLine("0 1 0 0.7 0");
			sb.AppendLine("0 0.7 0");
			sb.AppendLine("1 0 0 0.7 0");
			sb.AppendLine("0 0.7 0");
			sb.AppendLine("0 0 0 0.7 0");
			sb.AppendLine("-1 0.7 0");

			sb.AppendLine("1 1 0.1 0.1 0.8");
			sb.AppendLine("1 0.8 1");
			sb.AppendLine("0 1 0.1 0.1 0.8");
			sb.AppendLine("0 0.8 1");
			sb.AppendLine("1 0 0.1 0.1 0.8");
			sb.AppendLine("0 0.8 1");
			sb.AppendLine("0 0 0.1 0.1 0.8");
			sb.AppendLine("-1 0.8 1");

			sb.AppendLine("1 1 0.1 0.8 0.1");
			sb.AppendLine("1 0.8 0");
			sb.AppendLine("0 1 0.1 0.8 0.1");
			sb.AppendLine("0 0.8 0");
			sb.AppendLine("1 0 0.1 0.8 0.1");
			sb.AppendLine("0 0.8 0");
			sb.AppendLine("0 0 0.1 0.8 0.1");
			sb.AppendLine("-1 0.8 0");

			sb.AppendLine("1 1 0.1 0.8 0.1");
			sb.AppendLine("1 0.8 0");
			sb.AppendLine("0 1 0.1 0.8 0.1");
			sb.AppendLine("0 0.8 0");
			sb.AppendLine("1 0 0.1 0.8 0.1");
			sb.AppendLine("0 0.8 0");
			sb.AppendLine("0 0 0.1 0.8 0.1");
			sb.AppendLine("-1 0.8 0");

			sb.AppendLine("1 1 0.8 0.1 0.1");
			sb.AppendLine("1 0.8 -1");
			sb.AppendLine("0 1 0.8 0.1 0.1");
			sb.AppendLine("0 0.8 -1");
			sb.AppendLine("1 0 0.8 0.1 0.1");
			sb.AppendLine("0 0.8 -1");
			sb.AppendLine("0 0 0.8 0.1 0.1");
			sb.AppendLine("-1 0.8 -1");

			sb.AppendLine("1 1 0.1 0.2 0.7");
			sb.AppendLine("1 0.7 1");
			sb.AppendLine("0 1 0.1 0.2 0.7");
			sb.AppendLine("0 0.7 1");
			sb.AppendLine("1 0 0.1 0.2 0.7");
			sb.AppendLine("0 0.7 1");
			sb.AppendLine("0 0 0.1 0.2 0.7");
			sb.AppendLine("-1 0.7 1");

			sb.AppendLine("1 1 0.1 0.7 0.2");
			sb.AppendLine("1 0.7 0");
			sb.AppendLine("0 1 0.1 0.7 0.2");
			sb.AppendLine("0 0.7 0");
			sb.AppendLine("1 0 0.1 0.7 0.2");
			sb.AppendLine("0 0.7 0");
			sb.AppendLine("0 0 0.1 0.7 0.2");
			sb.AppendLine("-1 0.7 0");

			sb.AppendLine("1 1 0.2 0.7 0.1");
			sb.AppendLine("1 0.7 0");
			sb.AppendLine("0 1 0.2 0.7 0.1");
			sb.AppendLine("0 0.7 0");
			sb.AppendLine("1 0 0.2 0.7 0.1");
			sb.AppendLine("0 0.7 0");
			sb.AppendLine("0 0 0.2 0.7 0.1");
			sb.AppendLine("-1 0.7 0");

			sb.AppendLine("1 1 0.7 0.2 0.1");
			sb.AppendLine("1 0.7 -1");
			sb.AppendLine("0 1 0.7 0.2 0.1");
			sb.AppendLine("0 0.7 -1");
			sb.AppendLine("1 0 0.7 0.2 0.1");
			sb.AppendLine("0 0.7 -1");
			sb.AppendLine("0 0 0.7 0.2 0.1");
			sb.AppendLine("-1 0.7 -1");

			sb.AppendLine("1 1 0.1 0.3 0.6");
			sb.AppendLine("1 0.6 1");
			sb.AppendLine("0 1 0.1 0.3 0.6");
			sb.AppendLine("0 0.6 1");
			sb.AppendLine("1 0 0.1 0.3 0.6");
			sb.AppendLine("0 0.6 1");
			sb.AppendLine("0 0 0.1 0.3 0.6");
			sb.AppendLine("-1 0.6 1");

			sb.AppendLine("1 1 0.1 0.6 0.3");
			sb.AppendLine("1 0.6 0");
			sb.AppendLine("0 1 0.1 0.6 0.3");
			sb.AppendLine("0 0.6 0");
			sb.AppendLine("1 0 0.1 0.6 0.3");
			sb.AppendLine("0 0.6 0");
			sb.AppendLine("0 0 0.1 0.6 0.3");
			sb.AppendLine("-1 0.6 0");

			sb.AppendLine("1 1 0.3 0.6 0.1");
			sb.AppendLine("1 0.6 0");
			sb.AppendLine("0 1 0.3 0.6 0.1");
			sb.AppendLine("0 0.6 0");
			sb.AppendLine("1 0 0.3 0.6 0.1");
			sb.AppendLine("0 0.6 0");
			sb.AppendLine("0 0 0.3 0.6 0.1");
			sb.AppendLine("-1 0.6 0");

			sb.AppendLine("1 1 0.6 0.3 0.1");
			sb.AppendLine("1 0.6 -1");
			sb.AppendLine("0 1 0.6 0.3 0.1");
			sb.AppendLine("0 0.6 -1");
			sb.AppendLine("1 0 0.6 0.3 0.1");
			sb.AppendLine("0 0.6 -1");
			sb.AppendLine("0 0 0.6 0.3 0.1");
			sb.AppendLine("-1 0.6 -1");

			sb.AppendLine("1 1 0.1 0.4 0.5");
			sb.AppendLine("1 0.5 1");
			sb.AppendLine("0 1 0.1 0.4 0.5");
			sb.AppendLine("0 0.5 1");
			sb.AppendLine("1 0 0.1 0.4 0.5");
			sb.AppendLine("0 0.5 1");
			sb.AppendLine("0 0 0.1 0.4 0.5");
			sb.AppendLine("-1 0.5 1");

			sb.AppendLine("1 1 0.1 0.5 0.4");
			sb.AppendLine("1 0.5 0");
			sb.AppendLine("0 1 0.1 0.5 0.4");
			sb.AppendLine("0 0.5 0");
			sb.AppendLine("1 0 0.1 0.5 0.4");
			sb.AppendLine("0 0.5 0");
			sb.AppendLine("0 0 0.1 0.5 0.4");
			sb.AppendLine("-1 0.5 0");

			sb.AppendLine("1 1 0.4 0.5 0.1");
			sb.AppendLine("1 0.5 0");
			sb.AppendLine("0 1 0.4 0.5 0.1");
			sb.AppendLine("0 0.5 0");
			sb.AppendLine("1 0 0.4 0.5 0.1");
			sb.AppendLine("0 0.5 0");
			sb.AppendLine("0 0 0.4 0.5 0.1");
			sb.AppendLine("-1 0.5 0");

			sb.AppendLine("1 1 0.5 0.4 0.1");
			sb.AppendLine("1 0.5 -1");
			sb.AppendLine("0 1 0.5 0.4 0.1");
			sb.AppendLine("0 0.5 -1");
			sb.AppendLine("1 0 0.5 0.4 0.1");
			sb.AppendLine("0 0.5 -1");
			sb.AppendLine("0 0 0.5 0.4 0.1");
			sb.AppendLine("-1 0.5 -1");

			File.WriteAllText(TrainingSetForTwoAnswers.NETWORK_TRAIN_DATA_FILEPATH, sb.ToString());
		}
	}
}
