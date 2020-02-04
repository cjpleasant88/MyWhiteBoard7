using Microsoft.VisualStudio.TestTools.UnitTesting;

using ReverseString;

namespace ReverseStringTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetReverse_ILikeDogs()
        {
            Assert.AreEqual("sgoD ekiL I", ReverseString.Program.GetReverse("I Like Dogs"));
        }
        [TestMethod]
        public void GetReverse_SuperBowl()
        {
            Assert.AreEqual("lwoB repuS", ReverseString.Program.GetReverse("Super Bowl"));
        }
    }
}
