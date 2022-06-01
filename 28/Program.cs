using System;

namespace _28
{
	class Point
	{
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}
		public int X { get; set; }
		public int Y { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			Point start = new Point(0, 0);
			Point end = new Point(1, 0);
			Point a = new Point(10, 10);

			Point b = GetPointSymmetry(start, end, a);

			Console.WriteLine("X: {0} Y: {1}", b.X, b.Y);
		}

		private static Point GetPointSymmetry(Point start, Point end, Point point)
		{
			if (start.X == end.X)
			{
				return new Point(-point.X, point.Y);
			}
			else
			{
				return new Point(point.X, -point.Y);
			}
		}
	}
}
