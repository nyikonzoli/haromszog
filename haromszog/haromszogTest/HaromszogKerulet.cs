using Microsoft.VisualStudio.TestTools.UnitTesting;
using haromszog;

namespace haromszogTest
{
    [TestClass]
    public class HaromszogKerulet
    {
        [TestMethod]
        [DataRow(10, 10, 10, 30)]
        [DataRow(2, 9, 8, 19)]
        [DataRow(9823, 121, 9811, 19755)]
        public void KeruletCorrect(double a, double b, double c, double expected)
        {
            Haromszog h = new Haromszog(a, b, c);
            double result = h.kerulet();
            Assert.AreEqual(result, expected);
        }
    }
}
