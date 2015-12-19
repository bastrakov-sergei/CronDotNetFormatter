using CronDotNetFormatter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CronFormatterTest
{
    [TestClass]
    public class EveryTimeFormatterUnitTest
    {
        [TestMethod]
        public void FormatTestMethod()
        {
            ICronFormatter timeFormatter = new EveryTimeFormatter();

            string format = timeFormatter.Format();

            Assert.AreEqual(format, "*");
        }
    }
}
