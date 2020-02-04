using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinueLoop;

namespace ContinueLoopTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Position_A()
        {
            Assert.AreEqual(1, ContinueLoop.Program.Position('f', "football"));
        }
        [TestMethod]
        public void Position_B()
        {
            Assert.AreEqual(1, ContinueLoop.Program.Position('f', "football"));
        }
    }
}
