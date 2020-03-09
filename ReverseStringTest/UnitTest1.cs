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

        [TestMethod]
        public void GetReverse_null()
        {
            Assert.AreEqual("Null or empty Set", ReverseString.Program.GetReverse(null));
        }

        [TestMethod]
        public void GetReverse_Empty()
        {
            Assert.AreEqual("Null or empty Set", ReverseString.Program.GetReverse(""));
        }
    }
}
