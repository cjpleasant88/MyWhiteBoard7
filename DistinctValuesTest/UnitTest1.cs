using Microsoft.VisualStudio.TestTools.UnitTesting;
using DistinctValues;

namespace DistinctValuesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_5_Distinct()
        {
            int[] input = { 2, 7, 15, 15, 1, 10, 15, 2, 7 };
            Assert.AreEqual(5, Class1.DistinctValues(input));
        }

        [TestMethod]
        public void TestMethod_0()
        {
            int[] input = { };
            Assert.AreEqual(0, Class1.DistinctValues(input));
        }

        [TestMethod]
        public void TestMethod_1()
        {
            int[] input = { 17 };
            Assert.AreEqual(1, Class1.DistinctValues(input));
        }

        [TestMethod]
        public void TestMethod_Null()
        {
            int[] input = null;
            Assert.AreEqual(0, Class1.DistinctValues(input));
        }

        [TestMethod]
        public void TestMethod_Repetitive()
        {
            int[] input = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            Assert.AreEqual(1, Class1.DistinctValues(input));
        }

        [TestMethod]
        public void TestMethod_RepeatBeginning()
        {
            int[] input = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(9, Class1.DistinctValues(input));
        }

        [TestMethod]
        public void TestMethod_RepeatEnding()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9 };
            Assert.AreEqual(9, Class1.DistinctValues(input));
        }
    }
}
