using System;

namespace DZ_4
{
	/// <summary>
	/// Description of SimpleNgon.
	/// </summary>
	public interface SimpleNgon
	{
		double Height{ get; }
		double Baze{ get; }
		double BaseToSideAngle{ get; }
		double CountOfSides{ get; }
		double LengthOfSide(int N);
		double Square{ get; }
		double Perimeter{ get; }
	}
}
