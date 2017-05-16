using System;

namespace DZ_4
{
	public class Ellipse : GeometricFigure, ISimpleNgonable
	{
		public readonly double A, B;
		/// <summary>
		/// Эллипс
		/// </summary>
		/// <param name="A">Полуось A</param>
		/// <param name="B">Полуось B</param>
		public Ellipse(double A, double B)
		{
			if (A <= 0 || B <= 0)
				throw new NegativeSideException();
			this.A = A;
			this.B = B;
		}
		
		#region implemented abstract members of GeometricFigure
		public override double Square {
			get {
				return Math.PI * A * B;
			}
		}
		public override double Perimeter {
			get {
				return Math.PI * (3 * (A + B) - Math.Sqrt((3 * A + B) * (A + 3 * B)));
			}
		}
		#endregion
		
		#region implemented abstract members of SimpleNgon
		public double LengthOfSide(int N)
		{
			return 0;
		}
		public double Height {
			get {
				return 2 * B;
			}
		}
		public double Baze {
			get {
				return 2 * A;
			}
		}
		public double BaseToSideAngle {
			get {
				return 0;
			}
		}
		public double CountOfSides {
			get {
				return 0;
			}
		}
		#endregion
		
		public override string ToString()
		{
			return string.Format("[Ellipse A={0:#0.#}, B={1:#0.#}, " +
			"Perimeter={2:#0.#}, Square={3:#0.#}]",
				A, B, Perimeter, Square);
		}
	}
}
