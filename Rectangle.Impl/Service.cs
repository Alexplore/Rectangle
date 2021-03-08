using System;
using System.Collections.Generic;

namespace Rectangle.Impl
{
	public static class Service
	{
		/// <summary>
		/// See TODO.txt file for task details.
		/// Do not change contracts: input and output arguments, method name and access modifiers
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		public static Rectangle FindRectangle(List<Point> points) {
			if (points != null) {
				points = RemoveEqualPoints(points);
				if (points.Count > 1) {
					Rectangle rectangle = new Rectangle();
					Point[] extremePoints = FindExtremePoints(points);
					int width = Math.Abs(extremePoints[1].X - extremePoints[0].X) - 1;
					int height = Math.Abs(extremePoints[3].Y - extremePoints[2].Y);
					int leftX = (extremePoints[1].X > extremePoints[0].X) ? extremePoints[0].X : extremePoints[1].X;
					int lowerY = (extremePoints[3].Y > extremePoints[2].Y) ? extremePoints[2].Y : extremePoints[3].Y;
					rectangle.Width = width;
					rectangle.Height = height;
					if (rectangle.Width % 2 == 1)
					{
						rectangle.X = leftX + width / 2 + 1;
					}
					else {
						rectangle.X = leftX + width / 2;
					}
					if (rectangle.Height % 2 == 1)
					{
						rectangle.Y = lowerY + height / 2 + 1;
					}
					else
					{
						rectangle.Y = lowerY + height / 2;
					};
					return rectangle;
				}
			}
			return null;
		}

		/// <summary>
		/// Finds points, which distance is the biggest in X coordinates and in Y coordinates
		/// </summary>
		/// <param name="points"></param>
		/// <returns>Returns 4 points. First two is extreme points by X, last two - by Y </returns>
		public static Point[] FindExtremePoints(List<Point> points) {
			int maxWidth = 0;
			int maxHeight = 0;
			Point[] extremePoints = new Point[4];

			for (int i = 0; i < points.Count-1; i++)
            {
                for (int j = 1; j < points.Count; j++)
                {
					if ((Math.Abs(points[i].X - points[j].X)) > maxWidth) {
						maxWidth = Math.Abs(points[i].X - points[j].X);
						extremePoints[0] = points[i];
						extremePoints[1] = points[j];
					}
					if (Math.Abs(points[i].Y - points[j].Y) > maxHeight) {
						maxHeight = Math.Abs(points[i].Y - points[j].Y);
						extremePoints[2] = points[i];
						extremePoints[3] = points[j];
					}
                }
            }
			return extremePoints;
		}

		/// <summary>
		/// Removes points, which have at least one equal coordinate  
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		public static List<Point> RemoveEqualPoints(List<Point> points) {
			List<Point> newPoints = new List<Point>();
			bool isEqual;
            for (int i = 0; i < points.Count - 1; i++)
            {
				isEqual = false;
				for (int j = i + 1; j < points.Count; j++) {
					if (points[i].X == points[j].X || points[i].Y == points[j].Y) {
						isEqual = true;
					}
				}
				if (!isEqual) {
					newPoints.Add(points[i]);
				}
            }
			return newPoints;
		}
	}
}
