using FigureAreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator.Figures
{
    public class Triangle : IFigure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA.CompareTo(0) < 0)
                throw new ArgumentException("Parameter \"sideA\" is less than zero!");

            if (sideB.CompareTo(0) < 0)
                throw new ArgumentException("Parameter \"sideB\" is less than zero!");

            if (sideC.CompareTo(0) < 0)
                throw new ArgumentException("Parameter \"sideC\" is less than zero!");

            if (!CheckTriangleExistancePossibility(sideA, sideB, sideC))
                throw new ArgumentException("Triangle with specified sides can't exist!");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Area()
        {
            // Geron's formula

            var perimeterHalf = (SideA + SideB + SideC) / 2;

            var areaSquare = perimeterHalf * (perimeterHalf -  SideA) * (perimeterHalf - SideB)
                * (perimeterHalf - SideC);

            return Math.Sqrt(areaSquare);
        }

        public bool IsRight()
        {
            var sideA_square = Math.Pow(SideA, 2);
            var sideB_square = Math.Pow(SideB, 2);
            var sideC_square = Math.Pow(SideC, 2);

            if (sideA_square.CompareTo(sideB_square + sideC_square) == 0 ||
               sideB_square.CompareTo(sideA_square + sideC_square) == 0 ||
               sideC_square.CompareTo(sideB_square + sideA_square) == 0)
                return true;

            return false;
        }

        private bool CheckTriangleExistancePossibility(double sideA, double sideB, double sideC)
        {
            if(sideA.CompareTo(sideB + sideC) >= 0 ||
               sideB.CompareTo(sideA + sideC) >= 0 ||
               sideC.CompareTo(sideB + sideA) >= 0)
                return false;

            return true;
        }
    }
}
