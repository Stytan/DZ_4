using System;

namespace DZ_4
{
	public class Trapeze : GeometricFigure, ISimpleNgonable
	{
		private readonly double a, b;
		private readonly double c, d;
		private readonly float angle;
		public double A {
			get{ return a; }
		}
		public double B {
			get{ return b; }
		}
		public double C {
			get{ return c; }
		}
		public double D {
			get{ return d; }
		}
		public float Angle {
			get{ return angle; }
		}
		public double H {
			get{ return C * Math.Sin(Angle / 180 * Math.PI); }
		}
		/// <summary>
		/// Трапеция
		/// </summary>
		/// <param name="A">Длинна основания A</param>
		/// <param name="B">Длинна основания B</param>
		/// <param name="C">Длинна бедра</param>
		/// <param name="Angle">Угол между основанием A и бедром C</param>
		public Trapeze(double A, double B, double C, float Angle)
		{
			if (A <= 0 || B <= 0 || C <= 0)
				throw new NegativeSideException();
			if (Angle <= 0)
				throw new NegativeSideException("A negative value for the side of angle is set");
			if (Angle >= 180)
				throw new CreatingObjectException("Angle greater than 180");
			a = A;
			b = B;
			c = C;
			d = Math.Sqrt(Math.Pow(Math.Abs(A - B) - Math.Cos(Angle / 180 * Math.PI) * C, 2) + Math.Pow(H, 2));
			angle = Angle;
		}
		
		#region implemented abstract members of GeometricFigure
		public override double Square {
			get {
				return (A + B) * H / 2;
			}
		}
		public override double Perimeter {
			get {
				return A + B + C + D;
			}
		}
		#endregion
		
		#region implemented abstract members of SimpleNgon
		public double LengthOfSide(int N)
		{
			switch (N) {
				case 0:
					return A;
				case 1:
					return B;
				case 2:
					return C;
				case 3:
					return D;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
		public double Height {
			get {
				return H;
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
			return string.Format("[Trapeze A={0:#0.#}, B={1:#0.#}, C={2:#0.#}, Angle={3:#0.#} " +
			"H={4:#0.#}, Perimeter={5:#0.#}, Square={6:#0.#}]",
				a, b, c, angle, H, Perimeter, Square);
		}
	}
}
