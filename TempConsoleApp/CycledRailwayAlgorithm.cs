using System;
using System.Collections.Generic;

namespace TempConsoleApp
{
	class CycledRailwayAlgorithm
	{
		public static int GetLength(List<bool> list)
		{
			Direction direction = Direction.Right;
			int maximumSteps = 0;
			int currentSteps = 1;
			int currentIndex = NextIndex(0, direction, list.Count); 
			bool currentLight = list[0]; 

			do
			{
				if (list[currentIndex] == currentLight) 
				{
					currentLight = !currentLight;
					list[currentIndex] = currentLight;
					direction = direction.Opposite();
					if (maximumSteps < currentSteps)
					{
						maximumSteps = currentSteps;
					}
					else
					{
						if (maximumSteps == currentSteps)
							break;
					}
					currentSteps = 0;
				}
				else
				{
					list[currentIndex] = currentLight;
				}
				currentSteps++;
				currentIndex = NextIndex(currentIndex, direction, list.Count);
			} while (true);


			return Math.Max(currentSteps, maximumSteps);
		}

		private static int NextIndex(int currentIndex, Direction direction, int length)
		{
			if (direction == Direction.Left)
				return currentIndex > 0 ? currentIndex - 1 : length -1;
			return currentIndex < length - 1 ? currentIndex + 1 : 0;
		}
	}
}
