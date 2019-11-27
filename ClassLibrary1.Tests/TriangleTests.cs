using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Ctor_SideLessThanZero_ReturnException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-1, 3, 5));
        }

        [TestMethod]
        public void Ctor_SideBiggerThanOthersSum_ReturnException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(1, 10, 1));
        }

        [TestMethod]
        public void Ctor_NormalSides_NoExceptions()
        {
            try
            {
                new Triangle(3, 4, 5);
            }
            catch (Exception ex)
            {
                Assert.Fail("Получена ошибка при создании нормального треугольника: " + ex.Message);
            }
        }

        [TestMethod]
        public void IsRight_Right_ExpectsTrue()
        {
            Assert.IsTrue(new Triangle(3, 4, 5).IsRight);
        }
    }
}
