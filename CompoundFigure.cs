using System;
using System.Collections.Generic;

namespace DZ_4
{
	/// <summary>
	/// Description of CompoundFigure.
	/// </summary>
	public class CompoundFigure
	{
		private readonly List<GeometricFigure> figures;
		public List<GeometricFigure> Figures {
			get{ return figures; }
		}
		public CompoundFigure()
		{
			figures = new List<GeometricFigure>();
		}
		public double Square()
		{
			double Sum = 0;
			foreach (GeometricFigure f in figures)
				Sum += f.Square;
			return Sum;
		}
	}
}
