using Microsoft.VisualStudio.TestTools.UnitTesting;
using haromszog;

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
    }
}
