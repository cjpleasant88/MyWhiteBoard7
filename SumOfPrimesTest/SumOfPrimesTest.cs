using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfPrimes;

namespace SumOfPrimesTest
{
    [TestClass]
    public class SumOfPrimesTest
    {
        [TestMethod]
        public void TestMethod_5()
        {
            Assert.AreEqual(28, SumOfPrimes.SumOfPrimes.SumOfNPrimes(5));
        }

        [TestMethod]
        public void TestMethod_1()
        {
            Assert.AreEqual(2, SumOfPrimes.SumOfPrimes.SumOfNPrimes(1));
        }

        [TestMethod]
        public void TestMethod_0()
        {
            Assert.AreEqual(0, SumOfPrimes.SumOfPrimes.SumOfNPrimes(0));
        }

        [TestMethod]
        public void TestMethod_Neg4()
        {
            Assert.AreEqual(0, SumOfPrimes.SumOfPrimes.SumOfNPrimes(-4));
        }
    }
}
