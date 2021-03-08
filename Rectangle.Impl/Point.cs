﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle.Impl
{
	public sealed class Point
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Point(int x, int y) {
			this.X = x;
			this.Y = y;
		}
	}
}
