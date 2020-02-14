using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alphabetize;

namespace AlphabetizeTest
{
    [TestClass]
    public class AlphaTest
    {
        [TestMethod]
        public void TestMethod_MSSA_CAD()
        {
            Assert.AreEqual("acdms", Alpha.AlphabetizedString("MSSA CAD"));
        }

        [TestMethod]
        public void TestMethod_blankString()
        {
            Assert.AreEqual("", Alpha.AlphabetizedString(""));
        }

        [TestMethod]
        public void TestMethod_aaa()
        {
            Assert.AreEqual("a", Alpha.AlphabetizedString("aaaa aaaaa"));
        }

        [TestMethod]
        public void TestMethod_withPunct()
        {
            Assert.AreEqual("ceklnot", Alpha.AlphabetizedString("ten-o'clock"));
        }
    }
}
