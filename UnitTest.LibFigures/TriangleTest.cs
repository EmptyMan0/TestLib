using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest.LibFigures
{
    [TestClass]
    public class TriangleTest
	{ 
		[TestMethod]
		public void area_of_​​a_triangle()
		{
			double a = 3, b = 4, c = 5;
			var p = (a + b + c) / (2); //поиск полупериметра
			dynamic extr = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 
		    // act
			Triangle tr = new Triangle(a, b, c);
			var rez = tr.GetSquare();
			//assert
			Assert.AreEqual(extr, rez);
		}

		[TestMethod]
		public void ziro_triangle()
		{
			double a = 3, b = 4, c = 5;
			// act
			Triangle p = new Triangle(a, b, c);
			var rez = p.GetSquare();
			//assert
			Assert.IsNotNull(rez);
		}

	}
}

