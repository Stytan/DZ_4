using System;

namespace DZ_4
{
	/// <summary>
	/// Description of Foursquare.
	/// </summary>
	public class Foursquare : GeometricFigure, SimpleNgon
	{
		private readonly double a;
		public double A {
			get{ return a; }
		}
		public Foursquare(double A)
		{
			if (a <= 0)
				throw new NegativeSideException();
			a = A;
		}

		#region implemented abstract members of GeometricFigure
		public override double Square {
			get {
				return A*A;
			}
		}

		public override double Perimeter {
			get {
				return 4*A;
			}
		}
		#endregion

		#region implemented abstract members of SimpleNgon
		public double LengthOfSide(int N)
		{
			switch(N)
			{
				case 0:
				case 1:
				case 2:
				case 3:
					return A;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
		public double Height {
			get {
				return A;
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
			return string.Format("[Foursquare A={0:#0.#}, Perimeter={1:#0.#}, Square={2:#0.#}]",
			                     a, Perimeter, Square);
		}
	}
}
