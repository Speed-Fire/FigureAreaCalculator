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
    public class CircleTests
    {
        [TestMethod()]
        public void AreaTest()
        {
            var circle = new Circle(10);
            Assert.AreEqual(circle.Area(), 314.15, 0.01);

            circle = new Circle(0);
            Assert.AreEqual(circle.Area(), 0, 0.01);

            circle = new Circle(5.79);
            Assert.AreEqual(circle.Area(), 105.31, 0.01);
        }

        [TestMethod()]
        public void CircleTest()
        {
            var ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                var circle = new Circle(-5);
            });
            Assert.AreEqual(ex.Message, "Radius can't be less than zero!");

            ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                var circle = new Circle(Double.NegativeInfinity);
            });
            Assert.AreEqual(ex.Message, "Radius can't be less than zero!");

            ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                var circle = new Circle(Double.NaN);
            });
            Assert.AreEqual(ex.Message, "Radius can't be less than zero!");
        }
    }
}