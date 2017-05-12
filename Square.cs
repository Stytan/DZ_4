using System;

namespace DZ_4
{
	/// <summary>
	/// Description of Square.
	/// </summary>
	public class Square
	{
		private double a;
		public double A {
			get{ return a; }
		}
		public Square(double A)
		{
			if (a <= 0)
				throw new NegativeSideException();
			a = A;
		}
	}
}
