using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            //исходные данные
            int a = 3;
            int b = 5;
            int expeced = 15; //ожидаемое значение

        }
        [TestMethod]
        public void CalculateAreaInvalidDataTest1()
        {
            bool catched = false; //исключение было поймано
            try
            {
                //исходные данные
                int a = -4;
                int b = 10;

                Geometry g = new Geometry();
                g.CalculateArea(a, b);
            }
            catch (ArgumentException e)
            {
                catched = true;
            }
            Assert.IsTrue(catched, "не обработаны допустимые данные");
        }
        [TestMethod]
        public void CalculateAreaInvalidDataTest2()
        {
            //исходные данные
            int a = -4;
            int b = 10;
            //int expecred = 15; //ожидаемое значение

            //полученные значения с помощью тестируемого метода:
            Geometry g = new Geometry();
            int actual = g.CalculateArea(a, b);
            //сравнение ожидаемого результата с полученными:
            //Assert.AreEqual(expecred, actual);
            Assert.ThrowsException<ArgumentException>(() => g.CalculateArea(a, b),
                "не обработаны отрицательные длины сторон прямоугольника");
        }
    }
}
