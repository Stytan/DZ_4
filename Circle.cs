using System;

namespace DZ_4
{
	public class Circle : GeometricFigure, ISimpleNgonable
	{
		private readonly double r;
		public double R {
			get { return r; }
		}
		/// <summary>
		/// Круг
		/// </summary>
		/// <param name="R">Радиус</param>
		public Circle(double R)
		{
			if (R <= 0)
				throw new NegativeSideException();
			r = R;
		}

		#region implemented abstract members of GeometricFigure
		public override double Square {
			get {
				return Math.PI * R * R;
			}
		}

		public override double Perimeter {
			get {
				return 2 * Math.PI * R;
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
				return 2 * R;
			}
		}
		public double Baze {
			get {
				return 2 * R;
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
			return string.Format("[Circle R={0:#0.#}, " +
			"Perimeter={1:#0.#}, Square={2:#0.#}]",
				r, Perimeter, Square);
		}
	}
}
