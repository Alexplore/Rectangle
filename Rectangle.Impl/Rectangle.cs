using System;

namespace Rectangle.Impl
{
	public sealed class Rectangle
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public override string ToString() {
			return $"Rectangle\nX - {X}\nY - {Y}\nWidth - {Width}\nHeight - {Height}";
		}
	}
}
