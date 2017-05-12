using System;

namespace DZ_4
{
	/// <summary>
	/// Description of Rectangle.
	/// </summary>
	public class Rectangle
	{
		private double a, b;
		public double A {
			get{ return a; }
		}
		public double B {
			get{ return b; }
		}
		public Rectangle(double A, double B)
		{
			if (A <= 0 || B <= 0)
				throw new NegativeSideException();
			a = A;
			b = B;
		}
	}
}
