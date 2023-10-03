using FigureAreaCalculator.Figures;
using FigureAreaCalculator.Interfaces;

namespace ConsoleOutput
{
    public class Rectangle : IFigure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public double Area()
        {
            return SideA * SideB;
        }
    }   

    internal class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<IFigure>()
            {
                new Circle(6),
                new Triangle(3,4,5),
                new Triangle(10,15,12),
                new Circle(5.79),
                new Rectangle(4, 5)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine($"Area of figure = {figure.Area().ToString("0.##")}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any button to exit.");
        }
    }
}