using System;

namespace DZ_4
{
	/// <summary>
	/// Description of Parallelogram.
	/// </summary>
	public class Parallelogram : GeometricFigure, SimpleNgon
	{
		/// <summary>
		/// Стороны параллелограмма
		/// </summary>
		private readonly double a, b;
		/// <summary>
		/// Угол между сторонами (в градусах)
		/// </summary>
		private readonly float angle;
		/// <summary>
		/// Высота параллелограмма
		/// </summary>
		private readonly double h;
		public double A {
			get{ return a; }
		}
		public double B {
			get{ return b; }
		}
		public float Angle {
			get{ return angle; }
		}
		public double H {
			get{ return h; }
		}
		public Parallelogram(double A, double B, float Angle)
		{
			if (A <= 0 || B <= 0)
				throw new NegativeSideException();
			if (Angle <= 0)
				throw new NegativeSideException("A negative value for the side of angle is set");
			if (Angle >= 180)
				throw new CreatingObjectException("Angle greater than 180");
			a = A;
			b = B;
			angle = Angle;
			h = (A > B ? B : A) * Math.Sin(Angle / 180 * Math.PI);
		}
		public Parallelogram(double A, double B, double H)
		{
			if (A <= 0 || B <= 0 || H <= 0)
				throw new NegativeSideException();
			if (H > A && H > B)
				throw new CreatingObjectException("Parallelogram height greater than both sides");
			a = A;
			b = B;
			h = H;
			angle = (float) (Math.Asin(H / (A > B ? B : A)) * 180 / Math.PI);
		}
		public override double Perimeter {
			get {
				return (A + B) * 2;
			}
		}
		public override double Square {
			get {
				return H * (A > B ? A : B);
			}
		}
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
				return H;
			}
		}
		public double Baze {
			get {
				return (A > B ? A : B);
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
		public override string ToString()
		{
			return string.Format("[Parallelogram A={0:#0.#}, B={1:#0.#}, " +
			                     "Angle={2:#0.#}, H={3:#0.#}, Perimeter={4:#0.#}, Square={5:#0.#}]",
			                      a, b, angle, h, Perimeter, Square);
		}
	}
}
