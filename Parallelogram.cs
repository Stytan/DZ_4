using System;

namespace DZ_4
{
	/// <summary>
	/// Description of Parallelogram.
	/// </summary>
	public class Parallelogram
	{
		private double a, b;
		private double angle;
		public double A {
			get{ return a; }
		}
		public double B {
			get{ return b; }
		}
		public double Angle {
			get{ return angle; }
		}
		public Parallelogram(double A, double B, double Angle)
		{
			if (A <= 0 || B <= 0)
				throw new NegativeSideException();
			if (Angle <= 0)
				throw new NegativeSideException("A negative value for the side of angle is set");
			
		}
	}
}
