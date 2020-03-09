using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwapInts;

namespace SwapIntsTest
{
    [TestClass]
    public class SwapIntTest
    {
        [TestMethod]
        public void TestMethod_Swap()
        {
            int x = 1, y = 3;
            int X = 3, Y = 1;

            SwapInt.Swap(ref x, ref y);
            Assert.AreEqual(x, X);
            Assert.AreEqual(y, Y);
        }
    }
}
