using System;

namespace DZ_4
{
	/// <summary>
	/// Description of Rhombus.
	/// </summary>
	public class Rhombus : GeometricFigure, SimpleNgon
	{
		private readonly double a;
		private readonly double angle;
		public double A {
			get{ return a; }
		}
		public double Angle {
			get{ return angle; }
		}
		public Rhombus(double A, double Angle)
		{
			if (A <= 0)
				throw new NegativeSideException();
			if (Angle <= 0)
				throw new NegativeSideException("A negative value for the side of angle is set");
			if (Angle >= 180)
				throw new NegativeSideException("Angle greater than 180");
			a = A;
			angle = (Angle > 90 ? 180 - Angle : Angle);
		}

		#region implemented abstract members of GeometricFigure
		public override double Square {
			get {
				return A * A * Math.Sin(Angle / 180 * Math.PI);
			}
		}

		public override double Perimeter {
			get {
				return A * 4;
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
				return Math.Sin(Angle / 180 * Math.PI) * A;
			}
		}
		public double Baze {
			get {
				return A;
			}
		}
		public double BaseToSideAngle {
			get {
				return Angle;
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
			return string.Format("[Rhombus A={0:#0.#}, Angle={1:#0.#}" +
			                     "Perimeter={2:#0.#}, Square={3:#0.#]",
			                     a, angle, Perimeter, Square);
		}
	}
}
