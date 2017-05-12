using System;

namespace DZ_4
{
	/// <summary>
	/// Description of Rhombus.
	/// </summary>
	public class Rhombus
	{
		private double a;
		private double angle;
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
			angle = Angle;
		}
	}
}
