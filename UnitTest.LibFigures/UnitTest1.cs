using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.LibFigures
{
    [TestClass]
    public class UnitTest1
    {
        private int r = 20;
        private double a = 3;
        private double b = 4;
        private double c = 5;
        private dynamic ex = 1256.6371;
        private dynamic extr = 6;

        [TestMethod]
        public void area_of_​​a_circle()
        {
            // act
            Figures p = new Figures(r);
            var rez = p.area_of_a_circle();
            //assert
            Assert.AreEqual(ex, rez);
        }
		[TestMethod]
		public void ziro_circle()
		{
			// act
			Figures p = new Figures(r);
			var rez = p.area_of_a_circle();
			//assert
			Assert.IsNotNull(rez);

		}
		[TestMethod]
		public void area_of_​​a_triangle()
		{
			// act
			Figures p = new Figures(a, b, c);
			var rez = p.area_of_a_triangle();
			//assert
			Assert.AreEqual(extr, rez);
		}

		[TestMethod]
		public void ziro_triangle()
		{
			// act
			Figures p = new Figures(a, b, c);
			var rez = p.area_of_a_triangle();
			//assert
			Assert.IsNotNull(rez);
		}

	}
}

