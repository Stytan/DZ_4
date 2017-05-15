using System;

namespace DZ_4
{
	/// <summary>
	/// Description of Rectangle.
	/// </summary>
	public class Rectangle : GeometricFigure, SimpleNgon
	{
		private readonly double a, b;
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

		#region implemented abstract members of GeometricFigure
		public override double Square {
			get {
				return A * B;
			}
		}

		public override double Perimeter {
			get {
				return (A + B) * 2;
			}
		}
		#endregion
		
		#region implemented abstract members of SimpleNgon
		public double LengthOfSide(int N)
		{
			switch(N)
			{
				case 0:
				case 2:
					return A;
				case 1:
				case 3:
					return B;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
		public double Height {
			get {
				return B;
			}
		}
		public double Baze {
			get {
				return A;
			}
		}
		public double BaseToSideAngle {
			get {
				return 90;
			}
		}
		public double CountOfSides {
			get {
				return 4;
			}
		}
		#endregion
		
		public override string ToString()
		{
			return string.Format("[Rectangle A={0:#0.#}, B={1:#0.#}" +
			                     "Perimeter={2:#0.#}, Square={3:#0.#]",
			                     a, b, Perimeter, Square);
		}
	}
}
