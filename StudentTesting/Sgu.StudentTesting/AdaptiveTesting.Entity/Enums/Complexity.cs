using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveTesting.Entity.Enums
{
	public enum Complexity
	{
		Light = -1,
		Middle = 0,
		Hard = 1
	}
	public enum ComplexityWithNone
	{
		None = -2,
		Light = -1,
		Middle = 0,
		Hard = 1
	}

	public static class Levels
	{
		public static Dictionary<ComplexityWithNone, TestResult> LevelsDict = new Dictionary<ComplexityWithNone, TestResult>() {
		{ ComplexityWithNone.None, new TestResult(false, 2) },
		{ ComplexityWithNone.Light, new TestResult(true, 3) },
		{ ComplexityWithNone.Middle, new TestResult(true, 4) },
		{ ComplexityWithNone.Hard, new TestResult(true, 5) }
	};
	}

	public class TestResult
	{
		public bool IsTestCompleted { get; set; }
		public int Result { get; set; }

		public TestResult()
		{
		}

		public TestResult(bool isTestCompleted, int result)
		{
			IsTestCompleted = isTestCompleted;
			Result = result;
		}
	}
}
