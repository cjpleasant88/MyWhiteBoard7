using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountCapitals;

namespace CountCapitalsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Hello_World()
        {
            string input = "Hello World!";
            Assert.AreEqual(2, Program.CountCaptials(input));
        }

        [TestMethod]
        public void TestMethod_Empty()
        {
            string input = "";
            Assert.AreEqual(0, Program.CountCaptials(input));
        }
        [TestMethod]
        public void TestMethod_Null()
        {
            string input = null;
            Assert.AreEqual(0, Program.CountCaptials(input));
        }

        [TestMethod]
        public void TestMethod_Alphabet()
        {
            string input = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int expected = 26;
            int result = Program.CountCaptials(input);

            Assert.AreEqual(expected, result);
        }
    }
}
