using System;

namespace DZ_4
{
	/// <summary>
	/// Description of GeometricFigure.
	/// </summary>
	public abstract class GeometricFigure
	{
		private double square;
		private double perimeter;
		public double Square{
			get{ return square; }
		}
		public double Perimeter{
			get{ return perimeter; }
		}
	}
}
