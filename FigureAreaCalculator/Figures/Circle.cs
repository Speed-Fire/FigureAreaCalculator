using FigureAreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius.CompareTo(0) < 0)
                throw new ArgumentException("Radius can't be less than zero!");

            Radius = radius;
        }

        public double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
