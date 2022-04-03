namespace TempConsoleApp
{
	enum Direction
	{
		Left, Right
	}

	static class DirectionExtension
	{
		public static Direction Opposite(this Direction d)
		{
			return d == Direction.Left ? Direction.Right : Direction.Left;
		}
	}
}
