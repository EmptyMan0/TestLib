using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest.LibFigures
{
    [TestClass]
    public class CircleTest
	{

        [TestMethod]
        public void area_of_​​a_circle()
        {
            int r = 20;
            dynamic ex = Math.Round(Math.PI * Math.Pow(r, 2), 4);
            // act
            Circle p = new Circle(r);
            var rez = p.GetSquare();
            //assert
            Assert.AreEqual(ex, rez);
        }
        [TestMethod]
        public void ziro_circle()
        {
            int r = 20;
            // act
            Circle p = new Circle(r);
            var rez = p.GetSquare();
            //assert
            Assert.IsNotNull(rez);


        }
    }
}

