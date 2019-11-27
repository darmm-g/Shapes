using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class ShapeHelperTests
    {
        [TestMethod]
        public void GetArea_OneParameter_ReturnCircleArea()
        {
            Assert.AreEqual(ShapeHelper.GetArea(13), 530.929158456675);
        }
    }
}
