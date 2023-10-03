using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaCalculator.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator.Figures.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void AreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(triangle.Area(), 6, 0.01);

            triangle = new Triangle(10, 15, 12);
            Assert.AreEqual(triangle.Area(), 59.81, 0.01);
        }

        [TestMethod()]
        public void TriangleTest()
        {
            var ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                var triangle = new Triangle(Double.NaN, 4, 5);
            });
            Assert.AreEqual(ex.Message, "Parameter \"sideA\" is less than zero!");

            ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                var triangle = new Triangle(Double.NegativeInfinity, 4, 5);
            });
            Assert.AreEqual(ex.Message, "Parameter \"sideA\" is less than zero!");

            ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                var triangle = new Triangle(3, -4, 5);
            });
            Assert.AreEqual(ex.Message, "Parameter \"sideB\" is less than zero!");

            ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                var triangle = new Triangle(10, 13, 1);
            });
            Assert.AreEqual(ex.Message, "Triangle with specified sides can't exist!");
        }

        [TestMethod()]
        public void IsRightTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRight());

            triangle = new Triangle(10, 15, 12);
            Assert.IsFalse(triangle.IsRight());
        }
    }
}