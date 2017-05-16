using System;

namespace DZ_4
{
	/// <summary>
	/// Интерфейс Простой n-угольник
	/// </summary>
	public interface ISimpleNgonable
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
