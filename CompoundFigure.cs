using System;
using System.Collections.Generic;

namespace DZ_4
{
	/// <summary>
	/// Составная фигура
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
		public MyEnumerator GetEnumerator()
		{
			return new MyEnumerator(this);
		}
		public class MyEnumerator
		{
			int nIndex;
			CompoundFigure collection;
			public MyEnumerator(CompoundFigure coll)
			{
				collection = coll;
				nIndex = -1;
			}

			public bool MoveNext()
			{
				nIndex++;
				return(nIndex < collection.figures.Count);
			}

			public GeometricFigure Current {
				get {
					return(collection.figures[nIndex]);
				}
			}
		}
	}
}
