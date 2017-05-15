using System;

namespace DZ_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			var Figures = new CompoundFigure();
			Figures.Figures.Add(new Parallelogram(1555, 23, (float)90));
			Figures.Figures.Add(new Parallelogram(1555, 23, 23.0));
			Figures.Figures.Add(new Trapeze(20, 15, 5, 35));
			Figures.Figures.Add(new Trapeze(15, 20, 5, 35));
			Figures.Figures.Add(new Ellipse(20, 30));
			Figures.Figures.Add(new Circle(18));
			Figures.Figures.Add(new Foursquare(32));
			Figures.Figures.Add(new Rectangle(16, 35.6));
			Figures.Figures.Add(new Rhombus(21, 26));
			Figures.Figures.Add(new Triangle(8, 15, 12));
			
			foreach(GeometricFigure Figure in Figures)
			{
				Console.WriteLine(Figure);
				Console.WriteLine("Height = {0:0,#}, Base = {1:0,#}, Angle = {2:0,#}, " +
				"Count of side = {3:0,#}",
					(Figure as SimpleNgon).Height,
					(Figure as SimpleNgon).Baze,
					(Figure as SimpleNgon).BaseToSideAngle,
					(Figure as SimpleNgon).CountOfSides);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
