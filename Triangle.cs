using System;

namespace DZ_4
{
	/// <summary>
	/// Description of Triangle.
	/// </summary>
	public class Triangle : GeometricFigure
	{
		private double a, b, c;
		public double A{
			get{ return a; }
		}
		public double B{
			get{ return b; }
		}
		public double C{
			get{ return c; }
		}
		public Triangle(double A, double B, double C)
		{
			if (A < 0 || B < 0 || C < 0)
				throw new NegativeSideException();
			var halfsum = (A + B + C)/2;
			if (A >= halfsum || B >= halfsum || C >= halfsum)
				throw new CreatingObjectException();
			a = A;
			b = B;
			c = C;
		}
	}
}
