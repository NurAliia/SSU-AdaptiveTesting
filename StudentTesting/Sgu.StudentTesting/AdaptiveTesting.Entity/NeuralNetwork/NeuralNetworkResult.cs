using AdaptiveTesting.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveTesting.Entity
{
	public class NeuralNetworkResult
	{
		public ComplexityState ComplexityState { get; set; }

		public double Frequency { get; set; }
		public bool IsThemeCompleted
		{
			get
			{
				return Frequency >= 0.7;
			}
		}
		public Complexity CurrentComplexity { get; set; }

		public NeuralNetworkResult()
		{

		}
		public NeuralNetworkResult(double complexityState, double frequency, double complexity)
		{
			ComplexityState = (ComplexityState)Math.Round(complexityState);
			Frequency = Math.Round(frequency, 1);
			CurrentComplexity = (Complexity)Math.Round(complexity);
		}
	}
}
