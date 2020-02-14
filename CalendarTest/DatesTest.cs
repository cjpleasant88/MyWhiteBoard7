using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace CalendarTest
{
    [TestClass]
    public class DatesTest
    {
        [TestMethod]
        public void TestJulian_Jan()
        {
            Assert.AreEqual(1, Dates.JulianDay(1, 1));
        }
    }
}
