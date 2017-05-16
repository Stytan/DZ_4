using System;

namespace DZ_4
{
	public class Triangle : GeometricFigure, ISimpleNgonable
	{
		private readonly double a, b, c;
		public double A {
			get{ return a; }
		}
		public double B {
			get{ return b; }
		}
		public double C {
			get{ return c; }
		}
		/// <summary>
		/// Треугольник
		/// </summary>
		/// <param name="A">Сторона A</param>
		/// <param name="B">Сторона B</param>
		/// <param name="C">Основание C</param>
		public Triangle(double A, double B, double C)
		{
			if (A < 0 || B < 0 || C < 0)
				throw new NegativeSideException();
			var halfsum = (A + B + C) / 2;
			if (A >= halfsum || B >= halfsum || C >= halfsum)
				throw new CreatingObjectException();
			a = A;
			b = B;
			c = C;
		}

		#region implemented abstract members of GeometricFigure
		public override double Square {
			get {
				return Math.Sqrt((A + B + C) * (B + C - A) * (A + C - B) * (A + B - C)) / 4;
			}
		}

		public override double Perimeter {
			get {
				return A + B + C;
			}
		}
		#endregion
		
		#region implemented abstract members of SimpleNgon
		public double Height {
			get {
				double p = (A + B + C) / 2;
				return 2 * Math.Sqrt(p * (p - A) * (p - B) * (p - C)) / C;
			}
		}
		public double Baze {
			get {
				return C;
			}
		}
		public double BaseToSideAngle {
			get {
				return Math.Asin(Height / A) * 180 / Math.PI;
			}
		}
		public double CountOfSides {
			get {
				return 3;
			}
		}
		public double LengthOfSide(int N)
		{
			switch (N) {
				case 0:
					return A;
				case 1:
					return B;
				case 2:
					return C;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
		#endregion
		
		public override string ToString()
		{
			return string.Format("[Triangle A={0:#0.#}, B={1:#0.#}, C={2:#0.#}," +
			"Perimeter={3:#0.#}, Square={4:#0.#}]",
				a, b, c, Perimeter, Square);
		}
	}
}
