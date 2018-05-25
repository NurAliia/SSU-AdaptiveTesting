using AdaptiveTesting.Entity;
using FANNCSharp;
using FANNCSharp.Double;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveTesting.Entity
{
	public class NeuralNetworkForThreeAnswers
	{
		public const string NETWORK_FILEPATH = @"D:\AdaptiveTestingNNThreeAnsw.net";
		private NeuralNet _network;
		public NeuralNetworkForThreeAnswers()
		{
			if (!File.Exists(NETWORK_FILEPATH))
			{
				// слои
				List<uint> layers = new List<uint>();

				// количество нейронов входного слоя 
				layers.Add(6);

				// количество нейронов промежуточного слоя 
				layers.Add(12);

				// количество нейронов выходного слоя 
				layers.Add(3);

				// инициализация нейронной сети
				// первый параметр указывает на то, что сеть будет полносвязной
				_network = new NeuralNet(NetworkType.SHORTCUT, layers);

				// установка скорости обучения сети
				_network.LearningRate = (float)0.1;

				// параметры крутизны
				_network.ActivationSteepnessHidden = 1;
				_network.ActivationSteepnessOutput = 1;


				// функции активации
				_network.ActivationFunctionHidden = ActivationFunction.SIGMOID_SYMMETRIC;
				_network.ActivationFunctionOutput = ActivationFunction.SIGMOID_SYMMETRIC;

				// параметры обучения сети
				_network.TrainStopFunction = StopFunction.STOPFUNC_BIT;
				_network.BitFailLimit = 0.01;

				TrainNetwork();

				_network.Save(NETWORK_FILEPATH);
			}
			else
			{
				_network = new NeuralNet(NETWORK_FILEPATH);
			}
		}
		public void TrainNetwork()
		{
			// создаём тестовые данные, если они не были созданы ранее
			if (!File.Exists(TrainingSetForThreeAnswers.NETWORK_TRAIN_DATA_FILEPATH))
			{
				TrainingSetForThreeAnswers.CreateTrainingFile();
				Console.WriteLine("train data generated");
			}

			// загружаем данные
			TrainingData data = new TrainingData();
			data.ReadTrainFromFile(TrainingSetForThreeAnswers.NETWORK_TRAIN_DATA_FILEPATH);

			// определяем начальные веса
			_network.InitWeights(data);

			// определяем алгоритм обучения - будем использовать стандартный алгоритм распространения ошибки
			_network.TrainingAlgorithm = TrainingAlgorithm.TRAIN_INCREMENTAL;

			// обучаем сеть
			_network.TrainOnData(data, 10000000, 1000, 0);
		}
		public NeuralNetworkResult Test(int[] prevQuestionsAchievements, double[] frequencies)
		{
			int length = prevQuestionsAchievements.Length;
			double[] result = _network.Run(new double[] { prevQuestionsAchievements[length - 1], prevQuestionsAchievements[length - 2], prevQuestionsAchievements[length - 3], frequencies[0], frequencies[1], frequencies[2] });

			return new NeuralNetworkResult(result[0], result[1], result[2]);
		}
	}
}
