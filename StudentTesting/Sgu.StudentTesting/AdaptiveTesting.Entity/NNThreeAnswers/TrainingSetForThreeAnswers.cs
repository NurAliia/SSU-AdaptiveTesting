using AdaptiveTesting.Entity.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveTesting.Entity
{
	public static class TrainingSetForThreeAnswers
	{
		public const string NETWORK_TRAIN_DATA_FILEPATH = @"D:\TrainDataThreeAnswers.data";
		public static void CreateTrainingFile()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("313 6 3");

			sb.AppendLine("0 0 0 0 0 0");
			sb.AppendLine("-1 0 -1");

            //1
			sb.AppendLine("1 1 1 0 0 0.1");
			sb.AppendLine("1 0.1 1");
			sb.AppendLine("0 1 1 0 0 0.1");
			sb.AppendLine("0 0.1 1");
			sb.AppendLine("1 0 1 0 0 0.1");
			sb.AppendLine("0 0.1 1");
            sb.AppendLine("1 1 0 0 0 0.1");
            sb.AppendLine("0 0.1 1");
            sb.AppendLine("0 0 1 0 0 0.1");
            sb.AppendLine("-1 0.1 1");
            sb.AppendLine("0 1 0 0 0 0.1");
            sb.AppendLine("-1 0.1 1");
            sb.AppendLine("1 0 0 0 0 0.1");
            sb.AppendLine("-1 0.1 1");
            sb.AppendLine("0 0 0 0 0 0.1");
			sb.AppendLine("-1 0.1 1");

            //2
            sb.AppendLine("1 1 1 0 0 0.2");
            sb.AppendLine("1 0.2 1");
            sb.AppendLine("0 1 1 0 0 0.2");
            sb.AppendLine("0 0.2 1");
            sb.AppendLine("1 0 1 0 0 0.2");
            sb.AppendLine("0 0.2 1");
            sb.AppendLine("1 1 0 0 0 0.2");
            sb.AppendLine("0 0.2 1");
            sb.AppendLine("0 0 1 0 0 0.2");
            sb.AppendLine("-1 0.2 1");
            sb.AppendLine("0 1 0 0 0 0.2");
            sb.AppendLine("-1 0.2 1");
            sb.AppendLine("1 0 0 0 0 0.2");
            sb.AppendLine("-1 0.2 1");
            sb.AppendLine("0 0 0 0 0 0.2");
            sb.AppendLine("-1 0.2 1");

            //3
            sb.AppendLine("1 1 1 0 0 0.3");
            sb.AppendLine("1 0.3 1");
            sb.AppendLine("0 1 1 0 0 0.3");
            sb.AppendLine("0 0.3 1");
            sb.AppendLine("1 0 1 0 0 0.3");
            sb.AppendLine("0 0.3 1");
            sb.AppendLine("1 1 0 0 0 0.3");
            sb.AppendLine("0 0.3 1");
            sb.AppendLine("0 0 1 0 0 0.3");
            sb.AppendLine("-1 0.3 1");
            sb.AppendLine("0 1 0 0 0 0.3");
            sb.AppendLine("-1 0.3 1");
            sb.AppendLine("1 0 0 0 0 0.3");
            sb.AppendLine("-1 0.3 1");
            sb.AppendLine("0 0 0 0 0 0.3");
            sb.AppendLine("-1 0.3 1");
            
            //4
            sb.AppendLine("1 1 1 0 0 0.4");
            sb.AppendLine("1 0.4 1");
            sb.AppendLine("0 1 1 0 0 0.4");
            sb.AppendLine("0 0.4 1");
            sb.AppendLine("1 0 1 0 0 0.4");
            sb.AppendLine("0 0.4 1");
            sb.AppendLine("1 1 0 0 0 0.4");
            sb.AppendLine("0 0.4 1");
            sb.AppendLine("0 0 1 0 0 0.4");
            sb.AppendLine("-1 0.4 1");
            sb.AppendLine("0 1 0 0 0 0.4");
            sb.AppendLine("-1 0.4 1");
            sb.AppendLine("1 0 0 0 0 0.4");
            sb.AppendLine("-1 0.4 1");
            sb.AppendLine("0 0 0 0 0 0.4");
            sb.AppendLine("-1 0.4 1");

            //5
            sb.AppendLine("1 1 1 0 0 0.5");
            sb.AppendLine("1 0.5 1");
            sb.AppendLine("0 1 1 0 0 0.5");
            sb.AppendLine("0 0.5 1");
            sb.AppendLine("1 0 1 0 0 0.5");
            sb.AppendLine("0 0.5 1");
            sb.AppendLine("1 1 0 0 0 0.5");
            sb.AppendLine("0 0.5 1");
            sb.AppendLine("0 0 1 0 0 0.5");
            sb.AppendLine("-1 0.5 1");
            sb.AppendLine("0 1 0 0 0 0.5");
            sb.AppendLine("-1 0.5 1");
            sb.AppendLine("1 0 0 0 0 0.5");
            sb.AppendLine("-1 0.5 1");
            sb.AppendLine("0 0 0 0 0 0.5");
            sb.AppendLine("-1 0.5 1");

            //6
            sb.AppendLine("1 1 1 0 0 0.6");
            sb.AppendLine("1 0.6 1");
            sb.AppendLine("0 1 1 0 0 0.6");
            sb.AppendLine("0 0.6 1");
            sb.AppendLine("1 0 1 0 0 0.6");
            sb.AppendLine("0 0.6 1");
            sb.AppendLine("1 1 0 0 0 0.6");
            sb.AppendLine("0 0.6 1");
            sb.AppendLine("0 0 1 0 0 0.6");
            sb.AppendLine("-1 0.6 1");
            sb.AppendLine("0 1 0 0 0 0.6");
            sb.AppendLine("-1 0.6 1");
            sb.AppendLine("1 0 0 0 0 0.6");
            sb.AppendLine("-1 0.6 1");
            sb.AppendLine("0 0 0 0 0 0.6");
            sb.AppendLine("-1 0.6 1");

            //7
            sb.AppendLine("1 1 1 0 0 0.7");
            sb.AppendLine("1 0.7 1");
            sb.AppendLine("0 1 1 0 0 0.7");
            sb.AppendLine("0 0.7 1");
            sb.AppendLine("1 0 1 0 0 0.7");
            sb.AppendLine("0 0.7 1");
            sb.AppendLine("1 1 0 0 0 0.7");
            sb.AppendLine("0 0.7 1");
            sb.AppendLine("0 0 1 0 0 0.7");
            sb.AppendLine("-1 0.7 1");
            sb.AppendLine("0 1 0 0 0 0.7");
            sb.AppendLine("-1 0.7 1");
            sb.AppendLine("1 0 0 0 0 0.7");
            sb.AppendLine("-1 0.7 1");
            sb.AppendLine("0 0 0 0 0 0.7");
            sb.AppendLine("-1 0.7 1");


            ////////////////////////////////
            //8
            sb.AppendLine("1 1 1 0.1 0 0");
            sb.AppendLine("1 0.1 -1");
            sb.AppendLine("0 1 1 0.1 0 0");
            sb.AppendLine("0 0.1 -1");
            sb.AppendLine("1 0 1 0.1 0 0");
            sb.AppendLine("0 0.1 -1");
            sb.AppendLine("1 1 0 0.1 0 0");
            sb.AppendLine("0 0.1 -1");
            sb.AppendLine("0 0 1 0.1 0 0");
            sb.AppendLine("-1 0.1 -1");
            sb.AppendLine("0 1 0 0.1 0 0");
            sb.AppendLine("-1 0.1 -1");
            sb.AppendLine("1 0 0 0.1 0 0");
            sb.AppendLine("-1 0.1 -1");
            sb.AppendLine("0 0 0 0.1 0 0");
            sb.AppendLine("-1 0.1 -1");

            //9
            sb.AppendLine("1 1 1 0.2 0 0");
            sb.AppendLine("1 0.2 -1");
            sb.AppendLine("0 1 1 0.2 0 0");
            sb.AppendLine("0 0.2 -1");
            sb.AppendLine("1 0 1 0.2 0 0");
            sb.AppendLine("0 0.2 -1");
            sb.AppendLine("1 1 0 0.2 0 0");
            sb.AppendLine("0 0.2 -1");
            sb.AppendLine("0 0 1 0.2 0 0");
            sb.AppendLine("-1 0.2 -1");
            sb.AppendLine("0 1 0 0.2 0 0");
            sb.AppendLine("-1 0.2 -1");
            sb.AppendLine("1 0 0 0.2 0 0");
            sb.AppendLine("-1 0.2 -1");
            sb.AppendLine("0 0 0 0.2 0 0");
            sb.AppendLine("-1 0.2 -1");

            //10
            sb.AppendLine("1 1 1 0.3 0 0");
            sb.AppendLine("1 0.3 -1");
            sb.AppendLine("0 1 1 0.3 0 0");
            sb.AppendLine("0 0.3 -1");
            sb.AppendLine("1 0 1 0.3 0 0");
            sb.AppendLine("0 0.3 -1");
            sb.AppendLine("1 1 0 0.3 0 0");
            sb.AppendLine("0 0.3 -1");
            sb.AppendLine("0 0 1 0.3 0 0");
            sb.AppendLine("-1 0.3 -1");
            sb.AppendLine("0 1 0 0.3 0 0");
            sb.AppendLine("-1 0.3 -1");
            sb.AppendLine("1 0 0 0.3 0 0");
            sb.AppendLine("-1 0.3 -1");
            sb.AppendLine("0 0 0 0.3 0 0");
            sb.AppendLine("-1 0.3 -1");

            //11
            sb.AppendLine("1 1 1 0.4 0 0");
            sb.AppendLine("1 0.4 -1");
            sb.AppendLine("0 1 1 0.4 0 0");
            sb.AppendLine("0 0.4 -1");
            sb.AppendLine("1 0 1 0.4 0 0");
            sb.AppendLine("0 0.4 -1");
            sb.AppendLine("1 1 0 0.4 0 0");
            sb.AppendLine("0 0.4 -1");
            sb.AppendLine("0 0 1 0.4 0 0");
            sb.AppendLine("-1 0.4 -1");
            sb.AppendLine("0 1 0 0.4 0 0");
            sb.AppendLine("-1 0.4 -1");
            sb.AppendLine("1 0 0 0.4 0 0");
            sb.AppendLine("-1 0.4 -1");
            sb.AppendLine("0 0 0 0.4 0 0");
            sb.AppendLine("-1 0.4 -1");

            //12
            sb.AppendLine("1 1 1 0.5 0 0");
            sb.AppendLine("1 0.5 -1");
            sb.AppendLine("0 1 1 0.5 0 0");
            sb.AppendLine("0 0.5 -1");
            sb.AppendLine("1 0 1 0.5 0 0");
            sb.AppendLine("0 0.5 -1");
            sb.AppendLine("1 1 0 0.5 0 0");
            sb.AppendLine("0 0.5 -1");
            sb.AppendLine("0 0 1 0.5 0 0");
            sb.AppendLine("-1 0.5 -1");
            sb.AppendLine("0 1 0 0.5 0 0");
            sb.AppendLine("-1 0.5 -1");
            sb.AppendLine("1 0 0 0.5 0 0");
            sb.AppendLine("-1 0.5 -1");
            sb.AppendLine("0 0 0 0.5 0 0");
            sb.AppendLine("-1 0.5 -1");

            //13
            sb.AppendLine("1 1 1 0.6 0 0");
            sb.AppendLine("1 0.6 -1");
            sb.AppendLine("0 1 1 0.6 0 0");
            sb.AppendLine("0 0.6 -1");
            sb.AppendLine("1 0 1 0.6 0 0");
            sb.AppendLine("0 0.6 -1");
            sb.AppendLine("1 1 0 0.6 0 0");
            sb.AppendLine("0 0.6 -1");
            sb.AppendLine("0 0 1 0.6 0 0");
            sb.AppendLine("-1 0.6 -1");
            sb.AppendLine("0 1 0 0.6 0 0");
            sb.AppendLine("-1 0.6 -1");
            sb.AppendLine("1 0 0 0.6 0 0");
            sb.AppendLine("-1 0.6 -1");
            sb.AppendLine("0 0 0 0.6 0 0");
            sb.AppendLine("-1 0.6 -1");

            //14
            sb.AppendLine("1 1 1 0.7 0 0");
            sb.AppendLine("1 0.7 -1");
            sb.AppendLine("0 1 1 0.7 0 0");
            sb.AppendLine("0 0.7 -1");
            sb.AppendLine("1 0 1 0.7 0 0");
            sb.AppendLine("0 0.7 -1");
            sb.AppendLine("1 1 0 0.7 0 0");
            sb.AppendLine("0 0.7 -1");
            sb.AppendLine("0 0 1 0.7 0 0");
            sb.AppendLine("-1 0.7 -1");
            sb.AppendLine("0 1 0 0.7 0 0");
            sb.AppendLine("-1 0.7 -1");
            sb.AppendLine("1 0 0 0.7 0 0");
            sb.AppendLine("-1 0.7 -1");
            sb.AppendLine("0 0 0 0.7 0 0");
            sb.AppendLine("-1 0.7 -1");


            ///////////////////////////////
            //15
            sb.AppendLine("1 1 1 0 0.1 0");
            sb.AppendLine("1 0.1 0");
            sb.AppendLine("0 1 1 0 0.1 0");
            sb.AppendLine("0 0.1 0");
            sb.AppendLine("1 0 1 0 0.1 0");
            sb.AppendLine("0 0.1 0");
            sb.AppendLine("1 1 0 0 0.1 0");
            sb.AppendLine("0 0.1 0");
            sb.AppendLine("0 0 1 0 0.1 0");
            sb.AppendLine("-1 0.1 0");
            sb.AppendLine("0 1 0 0 0.1 0");
            sb.AppendLine("-1 0.1 0");
            sb.AppendLine("1 0 0 0 0.1 0");
            sb.AppendLine("-1 0.1 0");
            sb.AppendLine("0 0 0 0 0.1 0");
            sb.AppendLine("-1 0.1 0");

            //16
            sb.AppendLine("1 1 1 0 0.2 0");
            sb.AppendLine("1 0.2 0");
            sb.AppendLine("0 1 1 0 0.2 0");
            sb.AppendLine("0 0.2 0");
            sb.AppendLine("1 0 1 0 0.2 0");
            sb.AppendLine("0 0.2 0");
            sb.AppendLine("1 1 0 0 0.2 0");
            sb.AppendLine("0 0.2 0");
            sb.AppendLine("0 0 1 0 0.2 0");
            sb.AppendLine("-1 0.2 0");
            sb.AppendLine("0 1 0 0 0.2 0");
            sb.AppendLine("-1 0.2 0");
            sb.AppendLine("1 0 0 0 0.2 0");
            sb.AppendLine("-1 0.2 0");
            sb.AppendLine("0 0 0 0 0.2 0");
            sb.AppendLine("-1 0.2 0");

            //17
            sb.AppendLine("1 1 1 0 0.3 0");
            sb.AppendLine("1 0.3 0");
            sb.AppendLine("0 1 1 0 0.3 0");
            sb.AppendLine("0 0.3 0");
            sb.AppendLine("1 0 1 0 0.3 0");
            sb.AppendLine("0 0.3 0");
            sb.AppendLine("1 1 0 0 0.3 0");
            sb.AppendLine("0 0.3 0");
            sb.AppendLine("0 0 1 0 0.3 0");
            sb.AppendLine("-1 0.3 0");
            sb.AppendLine("0 1 0 0 0.3 0");
            sb.AppendLine("-1 0.3 0");
            sb.AppendLine("1 0 0 0 0.3 0");
            sb.AppendLine("-1 0.3 0");
            sb.AppendLine("0 0 0 0 0.3 0");
            sb.AppendLine("-1 0.3 0");

            //18
            sb.AppendLine("1 1 1 0 0.4 0");
            sb.AppendLine("1 0.4 0");
            sb.AppendLine("0 1 1 0 0.4 0");
            sb.AppendLine("0 0.4 0");
            sb.AppendLine("1 0 1 0 0.4 0");
            sb.AppendLine("0 0.4 0");
            sb.AppendLine("1 1 0 0 0.4 0");
            sb.AppendLine("0 0.4 0");
            sb.AppendLine("0 0 1 0 0.4 0");
            sb.AppendLine("-1 0.4 0");
            sb.AppendLine("0 1 0 0 0.4 0");
            sb.AppendLine("-1 0.4 0");
            sb.AppendLine("1 0 0 0 0.4 0");
            sb.AppendLine("-1 0.4 0");
            sb.AppendLine("0 0 0 0 0.4 0");
            sb.AppendLine("-1 0.4 0");

            //19
            sb.AppendLine("1 1 1 0 0.5 0");
            sb.AppendLine("1 0.5 0");
            sb.AppendLine("0 1 1 0 0.5 0");
            sb.AppendLine("0 0.5 0");
            sb.AppendLine("1 0 1 0 0.5 0");
            sb.AppendLine("0 0.5 0");
            sb.AppendLine("1 1 0 0 0.5 0");
            sb.AppendLine("0 0.5 0");
            sb.AppendLine("0 0 1 0 0.5 0");
            sb.AppendLine("-1 0.5 0");
            sb.AppendLine("0 1 0 0 0.5 0");
            sb.AppendLine("-1 0.5 0");
            sb.AppendLine("1 0 0 0 0.5 0");
            sb.AppendLine("-1 0.5 0");
            sb.AppendLine("0 0 0 0 0.5 0");
            sb.AppendLine("-1 0.5 0");

            //20
            sb.AppendLine("1 1 1 0 0.6 0");
            sb.AppendLine("1 0.6 0");
            sb.AppendLine("0 1 1 0 0.6 0");
            sb.AppendLine("0 0.6 0");
            sb.AppendLine("1 0 1 0 0.6 0");
            sb.AppendLine("0 0.6 0");
            sb.AppendLine("1 1 0 0 0.6 0");
            sb.AppendLine("0 0.6 0");
            sb.AppendLine("0 0 1 0 0.6 0");
            sb.AppendLine("-1 0.6 0");
            sb.AppendLine("0 1 0 0 0.6 0");
            sb.AppendLine("-1 0.6 0");
            sb.AppendLine("1 0 0 0 0.6 0");
            sb.AppendLine("-1 0.6 0");
            sb.AppendLine("0 0 0 0 0.6 0");
            sb.AppendLine("-1 0.6 0");

            //21
            sb.AppendLine("1 1 1 0 0.7 0");
            sb.AppendLine("1 0.7 0");
            sb.AppendLine("0 1 1 0 0.7 0");
            sb.AppendLine("0 0.7 0");
            sb.AppendLine("1 0 1 0 0.7 0");
            sb.AppendLine("0 0.7 0");
            sb.AppendLine("1 1 0 0 0.7 0");
            sb.AppendLine("0 0.7 0");
            sb.AppendLine("0 0 1 0 0.7 0");
            sb.AppendLine("-1 0.7 0");
            sb.AppendLine("0 1 0 0 0.7 0");
            sb.AppendLine("-1 0.7 0");
            sb.AppendLine("1 0 0 0 0.7 0");
            sb.AppendLine("-1 0.7 0");
            sb.AppendLine("0 0 0 0 0.7 0");
            sb.AppendLine("-1 0.7 0");


            /////////////////////////////
            //22
            sb.AppendLine("1 1 1 0.1 0.1 0.8");
            sb.AppendLine("1 0.8 1");
            sb.AppendLine("0 1 1 0.1 0.1 0.8");
            sb.AppendLine("0 0.8 1");
            sb.AppendLine("1 0 1 0.1 0.1 0.8");
            sb.AppendLine("0 0.8 1");
            sb.AppendLine("1 1 0 0.1 0.1 0.8");
            sb.AppendLine("0 0.8 1");
            sb.AppendLine("0 0 1 0.1 0.1 0.8");
            sb.AppendLine("-1 0.8 1");
            sb.AppendLine("0 1 0 0.1 0.1 0.8");
            sb.AppendLine("-1 0.8 1");
            sb.AppendLine("1 0 0 0.1 0.1 0.8");
            sb.AppendLine("-1 0.8 1");
            sb.AppendLine("0 0 0 0.1 0.1 0.8");
            sb.AppendLine("-1 0.8 1");

            //23
            sb.AppendLine("1 1 1 0.1 0.8 0.1");
            sb.AppendLine("1 0.8 0");
            sb.AppendLine("0 1 1 0.1 0.8 0.1");
            sb.AppendLine("0 0.8 0");
            sb.AppendLine("1 0 1 0.1 0.8 0.1");
            sb.AppendLine("0 0.8 0");
            sb.AppendLine("1 1 0 0.1 0.8 0.1");
            sb.AppendLine("0 0.8 0");
            sb.AppendLine("0 0 1 0.1 0.8 0.1");
            sb.AppendLine("-1 0.8 0");
            sb.AppendLine("0 1 0 0.1 0.8 0.1");
            sb.AppendLine("-1 0.8 0");
            sb.AppendLine("1 0 0 0.1 0.8 0.1");
            sb.AppendLine("-1 0.8 0");
            sb.AppendLine("0 0 0 0.1 0.8 0.1");
            sb.AppendLine("-1 0.8 0");

            //24
            sb.AppendLine("1 1 1 0.8 0.1 0.1");
            sb.AppendLine("1 0.8 -1");
            sb.AppendLine("0 1 1 0.8 0.1 0.1");
            sb.AppendLine("0 0.8 -1");
            sb.AppendLine("1 0 1 0.8 0.1 0.1");
            sb.AppendLine("0 0.8 -1");
            sb.AppendLine("1 1 0 0.8 0.1 0.1");
            sb.AppendLine("0 0.8 -1");
            sb.AppendLine("0 0 1 0.8 0.1 0.1");
            sb.AppendLine("-1 0.8 -1");
            sb.AppendLine("0 1 0 0.8 0.1 0.1");
            sb.AppendLine("-1 0.8 -1");
            sb.AppendLine("1 0 0 0.8 0.1 0.1");
            sb.AppendLine("-1 0.8 -1");
            sb.AppendLine("0 0 0 0.8 0.1 0.1");
            sb.AppendLine("-1 0.8 -1");

            //25
            sb.AppendLine("1 1 1 0.1 0.2 0.7");
            sb.AppendLine("1 0.7 1");
            sb.AppendLine("0 1 1 0.1 0.2 0.7");
            sb.AppendLine("0 0.7 1");
            sb.AppendLine("1 0 1 0.1 0.2 0.7");
            sb.AppendLine("0 0.7 1");
            sb.AppendLine("1 1 0 0.1 0.2 0.7");
            sb.AppendLine("0 0.7 1");
            sb.AppendLine("0 0 1 0.1 0.2 0.7");
            sb.AppendLine("-1 0.7 1");
            sb.AppendLine("0 1 0 0.1 0.2 0.7");
            sb.AppendLine("-1 0.7 1");
            sb.AppendLine("1 0 0 0.1 0.2 0.7");
            sb.AppendLine("-1 0.7 1");
            sb.AppendLine("0 0 0 0.1 0.2 0.7");
            sb.AppendLine("-1 0.7 1");

            //26
            sb.AppendLine("1 1 1 0.1 0.7 0.2");
            sb.AppendLine("1 0.7 0");
            sb.AppendLine("0 1 1 0.1 0.7 0.2");
            sb.AppendLine("0 0.7 0");
            sb.AppendLine("1 0 1 0.1 0.7 0.2");
            sb.AppendLine("0 0.7 0");
            sb.AppendLine("1 1 0 0.1 0.7 0.2");
            sb.AppendLine("0 0.7 0");
            sb.AppendLine("0 0 1 0.1 0.7 0.2");
            sb.AppendLine("-1 0.7 0");
            sb.AppendLine("0 1 0 0.1 0.7 0.2");
            sb.AppendLine("-1 0.7 0");
            sb.AppendLine("1 0 0 0.1 0.7 0.2");
            sb.AppendLine("-1 0.7 0");
            sb.AppendLine("0 0 0 0.1 0.7 0.2");
            sb.AppendLine("-1 0.7 0");

            //27
            sb.AppendLine("1 1 1 0.2 0.7 0.1");
            sb.AppendLine("1 0.7 0");
            sb.AppendLine("0 1 1 0.2 0.7 0.1");
            sb.AppendLine("0 0.7 0");
            sb.AppendLine("1 0 1 0.2 0.7 0.1");
            sb.AppendLine("0 0.7 0");
            sb.AppendLine("1 1 0 0.2 0.7 0.1");
            sb.AppendLine("0 0.7 0");
            sb.AppendLine("0 0 1 0.2 0.7 0.1");
            sb.AppendLine("-1 0.7 0");
            sb.AppendLine("0 1 0 0.2 0.7 0.1");
            sb.AppendLine("-1 0.7 0");
            sb.AppendLine("1 0 0 0.2 0.7 0.1");
            sb.AppendLine("-1 0.7 0");
            sb.AppendLine("0 0 0 0.2 0.7 0.1");
            sb.AppendLine("-1 0.7 0");

            //28
            sb.AppendLine("1 1 1 0.7 0.2 0.1");
            sb.AppendLine("1 0.7 -1");
            sb.AppendLine("0 1 1 0.7 0.2 0.1");
            sb.AppendLine("0 0.7 -1");
            sb.AppendLine("1 0 1 0.7 0.2 0.1");
            sb.AppendLine("0 0.7 -1");
            sb.AppendLine("1 1 0 0.7 0.2 0.1");
            sb.AppendLine("0 0.7 -1");
            sb.AppendLine("0 0 1 0.7 0.2 0.1");
            sb.AppendLine("-1 0.7 -1");
            sb.AppendLine("0 1 0 0.7 0.2 0.1");
            sb.AppendLine("-1 0.7 -1");
            sb.AppendLine("1 0 0 0.7 0.2 0.1");
            sb.AppendLine("-1 0.7 -1");
            sb.AppendLine("0 0 0 0.7 0.2 0.1");
            sb.AppendLine("-1 0.7 -1");

            //29
            sb.AppendLine("1 1 1 0.1 0.3 0.6");
            sb.AppendLine("1 0.6 1");
            sb.AppendLine("0 1 1 0.1 0.3 0.6");
            sb.AppendLine("0 0.6 1");
            sb.AppendLine("1 0 1 0.1 0.3 0.6");
            sb.AppendLine("0 0.6 1");
            sb.AppendLine("1 1 0 0.1 0.3 0.6");
            sb.AppendLine("0 0.6 1");
            sb.AppendLine("0 0 1 0.1 0.3 0.6");
            sb.AppendLine("-1 0.6 1");
            sb.AppendLine("0 1 0 0.1 0.3 0.6");
            sb.AppendLine("-1 0.6 1");
            sb.AppendLine("1 0 0 0.1 0.3 0.6");
            sb.AppendLine("-1 0.6 1");
            sb.AppendLine("0 0 0 0.1 0.3 0.6");
            sb.AppendLine("-1 0.6 1");

            //30
            sb.AppendLine("1 1 1 0.1 0.6 0.3");
            sb.AppendLine("1 0.6 0");
            sb.AppendLine("0 1 1 0.1 0.6 0.3");
            sb.AppendLine("0 0.6 0");
            sb.AppendLine("1 0 1 0.1 0.6 0.3");
            sb.AppendLine("0 0.6 0");
            sb.AppendLine("1 1 0 0.1 0.6 0.3");
            sb.AppendLine("0 0.6 0");
            sb.AppendLine("0 0 1 0.1 0.6 0.3");
            sb.AppendLine("-1 0.6 0");
            sb.AppendLine("0 1 0 0.1 0.6 0.3");
            sb.AppendLine("-1 0.6 0");
            sb.AppendLine("1 0 0 0.1 0.6 0.3");
            sb.AppendLine("-1 0.6 0");
            sb.AppendLine("0 0 0 0.1 0.6 0.3");
            sb.AppendLine("-1 0.6 0");

            //31
            sb.AppendLine("1 1 1 0.3 0.6 0.1");
            sb.AppendLine("1 0.6 0");
            sb.AppendLine("0 1 1 0.3 0.6 0.1");
            sb.AppendLine("0 0.6 0");
            sb.AppendLine("1 0 1 0.3 0.6 0.1");
            sb.AppendLine("0 0.6 0");
            sb.AppendLine("1 1 0 0.3 0.6 0.1");
            sb.AppendLine("0 0.6 0");
            sb.AppendLine("0 0 1 0.3 0.6 0.1");
            sb.AppendLine("-1 0.6 0");
            sb.AppendLine("0 1 0 0.3 0.6 0.1");
            sb.AppendLine("-1 0.6 0");
            sb.AppendLine("1 0 0 0.3 0.6 0.1");
            sb.AppendLine("-1 0.6 0");
            sb.AppendLine("0 0 0 0.3 0.6 0.1");
            sb.AppendLine("-1 0.6 0");

            //32
            sb.AppendLine("1 1 1 0.6 0.3 0.1");
            sb.AppendLine("1 0.6 -1");
            sb.AppendLine("0 1 1 0.6 0.3 0.1");
            sb.AppendLine("0 0.6 -1");
            sb.AppendLine("1 0 1 0.6 0.3 0.1");
            sb.AppendLine("0 0.6 -1");
            sb.AppendLine("1 1 0 0.6 0.3 0.1");
            sb.AppendLine("0 0.6 -1");
            sb.AppendLine("0 0 1 0.6 0.3 0.1");
            sb.AppendLine("-1 0.6 -1");
            sb.AppendLine("0 1 0 0.6 0.3 0.1");
            sb.AppendLine("-1 0.6 -1");
            sb.AppendLine("1 0 0 0.6 0.3 0.1");
            sb.AppendLine("-1 0.6 -1");
            sb.AppendLine("0 0 0 0.6 0.3 0.1");
            sb.AppendLine("-1 0.6 -1");

            //33
            sb.AppendLine("1 1 1 0.1 0.4 0.5");
            sb.AppendLine("1 0.5 1");
            sb.AppendLine("0 1 1 0.1 0.4 0.5");
            sb.AppendLine("0 0.5 1");
            sb.AppendLine("1 0 1 0.1 0.4 0.5");
            sb.AppendLine("0 0.5 1");
            sb.AppendLine("1 1 0 0.1 0.4 0.5");
            sb.AppendLine("0 0.5 1");
            sb.AppendLine("0 0 1 0.1 0.4 0.5");
            sb.AppendLine("-1 0.5 1");
            sb.AppendLine("0 1 0 0.1 0.4 0.5");
            sb.AppendLine("-1 0.5 1");
            sb.AppendLine("1 0 0 0.1 0.4 0.5");
            sb.AppendLine("-1 0.5 1");
            sb.AppendLine("0 0 0 0.1 0.4 0.5");
            sb.AppendLine("-1 0.5 1");

            //34
            sb.AppendLine("1 1 1 0.1 0.5 0.4");
            sb.AppendLine("1 0.5 0");
            sb.AppendLine("0 1 1 0.1 0.5 0.4");
            sb.AppendLine("0 0.5 0");
            sb.AppendLine("1 0 1 0.1 0.5 0.4");
            sb.AppendLine("0 0.5 0");
            sb.AppendLine("1 1 0 0.1 0.5 0.4");
            sb.AppendLine("0 0.5 0");
            sb.AppendLine("0 0 1 0.1 0.5 0.4");
            sb.AppendLine("-1 0.5 0");
            sb.AppendLine("0 1 0 0.1 0.5 0.4");
            sb.AppendLine("-1 0.5 0");
            sb.AppendLine("1 0 0 0.1 0.5 0.4");
            sb.AppendLine("-1 0.5 0");
            sb.AppendLine("0 0 0 0.1 0.5 0.4");
            sb.AppendLine("-1 0.5 0");

            //35
            sb.AppendLine("1 1 1 0.4 0.5 0.1");
            sb.AppendLine("1 0.5 0");
            sb.AppendLine("0 1 1 0.4 0.5 0.1");
            sb.AppendLine("0 0.5 0");
            sb.AppendLine("1 0 1 0.4 0.5 0.1");
            sb.AppendLine("0 0.5 0");
            sb.AppendLine("1 1 0 0.4 0.5 0.1");
            sb.AppendLine("0 0.5 0");
            sb.AppendLine("0 0 1 0.4 0.5 0.1");
            sb.AppendLine("-1 0.5 0");
            sb.AppendLine("0 1 0 0.4 0.5 0.1");
            sb.AppendLine("-1 0.5 0");
            sb.AppendLine("1 0 0 0.4 0.5 0.1");
            sb.AppendLine("-1 0.5 0");
            sb.AppendLine("0 0 0 0.4 0.5 0.1");
            sb.AppendLine("-1 0.5 0");

            //36
            sb.AppendLine("1 1 1 0.5 0.4 0.1");
            sb.AppendLine("1 0.5 -1");
            sb.AppendLine("0 1 1 0.5 0.4 0.1");
            sb.AppendLine("0 0.5 -1");
            sb.AppendLine("1 0 1 0.5 0.4 0.1");
            sb.AppendLine("0 0.5 -1");
            sb.AppendLine("1 1 0 0.5 0.4 0.1");
            sb.AppendLine("0 0.5 -1");
            sb.AppendLine("0 0 1 0.5 0.4 0.1");
            sb.AppendLine("-1 0.5 -1");
            sb.AppendLine("0 1 0 0.5 0.4 0.1");
            sb.AppendLine("-1 0.5 -1");
            sb.AppendLine("1 0 0 0.5 0.4 0.1");
            sb.AppendLine("-1 0.5 -1");
            sb.AppendLine("0 0 0 0.5 0.4 0.1");
            sb.AppendLine("-1 0.5 -1");

            //37
            sb.AppendLine("1 1 1 0.3 0.3 0.4");
            sb.AppendLine("1 0.4 1");
            sb.AppendLine("0 1 1 0.3 0.3 0.4");
            sb.AppendLine("0 0.4 1");
            sb.AppendLine("1 0 1 0.3 0.3 0.4");
            sb.AppendLine("0 0.4 1");
            sb.AppendLine("1 1 0 0.3 0.3 0.4");
            sb.AppendLine("0 0.4 1");
            sb.AppendLine("0 0 1 0.3 0.3 0.4");
            sb.AppendLine("-1 0.4 1");
            sb.AppendLine("0 1 0 0.3 0.3 0.4");
            sb.AppendLine("-1 0.4 1");
            sb.AppendLine("1 0 0 0.3 0.3 0.4");
            sb.AppendLine("-1 0.4 1");
            sb.AppendLine("0 0 0 0.3 0.3 0.4");
            sb.AppendLine("-1 0.4 1");

            //38
            sb.AppendLine("1 1 1 0.4 0.3 0.3");
            sb.AppendLine("1 0.4 -1");
            sb.AppendLine("0 1 1 0.4 0.3 0.3");
            sb.AppendLine("0 0.4 -1");
            sb.AppendLine("1 0 1 0.4 0.3 0.3");
            sb.AppendLine("0 0.4 -1");
            sb.AppendLine("1 1 0 0.4 0.3 0.3");
            sb.AppendLine("0 0.4 -1");
            sb.AppendLine("0 0 1 0.4 0.3 0.3");
            sb.AppendLine("-1 0.4 -1");
            sb.AppendLine("0 1 0 0.4 0.3 0.3");
            sb.AppendLine("-1 0.4 -1");
            sb.AppendLine("1 0 0 0.4 0.3 0.3");
            sb.AppendLine("-1 0.4 -1");
            sb.AppendLine("0 0 0 0.4 0.3 0.3");
            sb.AppendLine("-1 0.4 -1");

            //39
            sb.AppendLine("1 1 1 0.3 0.4 0.3");
            sb.AppendLine("1 0.4 0");
            sb.AppendLine("0 1 1 0.3 0.4 0.3");
            sb.AppendLine("0 0.4 0");
            sb.AppendLine("1 0 1 0.3 0.4 0.3");
            sb.AppendLine("0 0.4 0");
            sb.AppendLine("1 1 0 0.3 0.4 0.3");
            sb.AppendLine("0 0.4 0");
            sb.AppendLine("0 0 1 0.3 0.4 0.3");
            sb.AppendLine("-1 0.4 0");
            sb.AppendLine("0 1 0 0.3 0.4 0.3");
            sb.AppendLine("-1 0.4 0");
            sb.AppendLine("1 0 0 0.3 0.4 0.3");
            sb.AppendLine("-1 0.4 0");
            sb.AppendLine("0 0 0 0.3 0.4 0.3");
            sb.AppendLine("-1 0.4 0");

            File.WriteAllText(TrainingSetForThreeAnswers.NETWORK_TRAIN_DATA_FILEPATH, sb.ToString());
		}
	}
}
