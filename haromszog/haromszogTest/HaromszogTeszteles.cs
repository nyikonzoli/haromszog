using Microsoft.VisualStudio.TestTools.UnitTesting;
using haromszog;
using System;

namespace haromszogTest
{
    [TestClass]
    public class HaromszogTeszteles
    {
        [TestMethod]
        [DataRow(10, 10, 10)]
        [DataRow(2, 9, 8)]
        [DataRow(9823, 121, 9811)]
        public void SzerkeszthetoReturnTrue(double a, double b, double c)
        {
            Haromszog h = new Haromszog(a, b, c);
            bool result = h.szerkesztheto();
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(0, 10, 10)]
        [DataRow(2, 3, 8)]
        [DataRow(1, 111, 1)]
        public void SzerkeszthetoThrowException(double a, double b, double c)
        {
            Haromszog h = new Haromszog(a, b, c);
            try
            {
                bool result = h.szerkesztheto();
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is HaromszogException);
            }
        }
    }
}
