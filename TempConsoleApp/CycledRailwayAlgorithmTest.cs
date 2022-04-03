using System.Collections.Generic;
using NUnit.Framework;

namespace TempConsoleApp
{
	[TestFixture]
	class CycledRailwayAlgorithmTest
	{
		private static readonly object[] _data =
		{
			new object[] {new List<bool> {true}},
			new object[] {new List<bool> {false, false, false, false}},
			new object[] {new List<bool> {true, false, false, false}},
			new object[] {new List<bool> {true, false, true, false}},
			new object[] {new List<bool> {false, true, true, true}},
		};

		[Test, TestCaseSource(nameof(_data))]
		public void CycledRailwayAlgorithm_Input_data_ReturnCorrectLength(List<bool> list)
		{
			int expectedLength = list.Count;
			int actualLength = CycledRailwayAlgorithm.GetLength(list);

			Assert.AreEqual(expectedLength, actualLength);
		}
	}
}
