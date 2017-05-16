using System;

namespace DZ_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			var CompFigure = new CompoundFigure();
			CompFigure.Figures.Add(new Parallelogram(1555, 23, (float)90));
			CompFigure.Figures.Add(new Parallelogram(1555, 23, 23.0));
			CompFigure.Figures.Add(new Trapeze(20, 15, 5, 35));
			CompFigure.Figures.Add(new Trapeze(15, 20, 5, 35));
			CompFigure.Figures.Add(new Ellipse(20, 30));
			CompFigure.Figures.Add(new Circle(18));
			CompFigure.Figures.Add(new Foursquare(32));
			CompFigure.Figures.Add(new Rectangle(16, 35.6));
			CompFigure.Figures.Add(new Rhombus(21, 26));
			CompFigure.Figures.Add(new Triangle(8, 15, 12));
			foreach(GeometricFigure Figure in CompFigure)
			{
				Console.WriteLine(Figure);
				Console.WriteLine("Height={0:0.#}, Base={1:0.#}, Angle={2:0.#}, " +
				"Count of side={3:0.#}\n",
					(Figure as ISimpleNgonable).Height,
					(Figure as ISimpleNgonable).Baze,
					(Figure as ISimpleNgonable).BaseToSideAngle,
					(Figure as ISimpleNgonable).CountOfSides);
			}
			Console.WriteLine("The square of CompoundFigure = {0:0.#}", CompFigure.Square());
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
