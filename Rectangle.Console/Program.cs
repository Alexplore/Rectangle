using System;
using System.Collections.Generic;
using Rectangle.Impl;

namespace Rectangle.Console
{
    class Program
	{
		/// <summary>
		/// Use this method for local debugging only. The implementation should remain in Rectangle.Impl project.
		/// See TODO.txt file for task details.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			var points = GetPointList(500);
			var rectangle = Service.FindRectangle(points);
			points = Service.RemoveEqualPoints(points);
			if (rectangle == null) {
                System.Console.WriteLine("Rectangle is not found!");
				return;
			}
            for (int i = 0; i < points.Count; i++)
            {
                System.Console.WriteLine($"Point {i + 1}. Coordinates : x - {points[i].X}, y - {points[i].Y}");
            }
			for (int i = 0; i < points.Count; i++) {
				if (points[i].X > (rectangle.X + rectangle.Width/2)|| points[i].Y > (rectangle.Y + rectangle.Height / 2)) {
                    System.Console.WriteLine($"Point {i+1} is out of rectangle");
				}
			}
            System.Console.WriteLine(rectangle.ToString());
			System.Console.ReadKey();
		}

		public static List<Point> GetPointList(int count) {
			List<Point> points = new List<Point>();
			for (int i = 0; i < count; i++)
			{
				int x = new Random().Next(0, 100);
				int y = new Random().Next(0, 100);
				points.Add(new Point(x, y));
			}
			return points;
		}
	}
}
