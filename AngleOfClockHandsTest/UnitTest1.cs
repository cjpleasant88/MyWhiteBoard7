using Microsoft.VisualStudio.TestTools.UnitTesting;
using AngleOfClockHands;

namespace AngleOfClockHandsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_12_15()
        {
            Assert.AreEqual(90, AngleOfClockHands.Program.HandsAngle(12, 15));
        }

        [TestMethod]
        public void TestMethod_1_45()
        {
            Assert.AreEqual(120, AngleOfClockHands.Program.HandsAngle(1, 45));
        }

        [TestMethod]
        public void TestMethod_13_15()
        {
            Assert.AreEqual(90, AngleOfClockHands.Program.HandsAngle(12, 15));
        }
    }
}
