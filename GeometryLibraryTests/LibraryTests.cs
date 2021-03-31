using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Tests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void CreateCircleException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-1), "Radius must be equal or greater than zero");
        }
        [TestMethod]
        public void AreaCircle()
        {
            Circle n = new Circle(10);

            Assert.AreEqual(314.1592653589793, n.GetArea());
        }
        [TestMethod]
        public void CreateTriangleException1()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(10, 10, -1), "All sides must be equal or greater than zero");
        }

        [TestMethod]
        public void CreateTriangleException2()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(10, 3, 1), "Input error. Some sides must be longer");
        }
        [TestMethod]
        public void AreaTriangle()
        {
            Triangle n = new Triangle(10, 10, 10);

            Assert.AreEqual(43.30127018922193, n.GetArea());
        }

        [TestMethod]
        public void RightTriangleFalse()
        {
            Triangle n = new Triangle(10, 10, 10);

            Assert.AreEqual(false, n.IsRightTriangle());
        }

        [TestMethod]
        public void RightTriangleTrue()
        {
            Triangle n = new Triangle(8, 6, 10);

            Assert.AreEqual(true, n.IsRightTriangle());
        }

        [TestMethod]
        public void Square()
        {
            Square n = new Square(12);

            Assert.AreEqual(144, n.GetArea());
        }
    }
}