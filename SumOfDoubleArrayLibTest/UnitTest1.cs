using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfDoubleArrayLib;

namespace SumOfDoubleArrayLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_5_PosDoubles()
        {
            double[] array = { 1.0, 2.5, 4.6, 1.4, 0.5 };
            double result = Class1.Sum(array);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMethod_5_NegDoubles()
        {
            double[] array = { -1.0, -2.5, -4.6, -1.4, -0.5 };
            double result = Class1.Sum(array);

            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void TestMethod_5_CombinationDoubles()
        {
            double[] array = { -1.0, 2.5, -4.6, -1.4, 0.5 };
            double result = Class1.Sum(array);

            Assert.AreEqual(-4, result);
        }

        [TestMethod]
        public void TestMethod_0()
        {
            double[] array = {  };
            double result = Class1.Sum(array);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod_Null()
        {
            double[] array = null;
            double result = Class1.Sum(array);

            Assert.AreEqual(0, result);
        }
    }
}
