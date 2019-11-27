using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
namespace ClassLibrary1.Tests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void GetArea_OnShapeObj_ReturnRightArea()
        {
            Shape shape = new Circle(23);
            Circle circle = new Circle(23);
            Assert.AreEqual(shape.GetArea(), circle.GetArea());
        }
    }
}
