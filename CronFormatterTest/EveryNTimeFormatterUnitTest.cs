using System;
using CronDotNetFormatter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CronFormatterTest
{
    [TestClass]
    public class EveryNTimeFormatterUnitTest
    {
        [TestMethod]
        public void NormalFormatTestMethod()
        {
            ICronFormatter timeFormatter = new EveryNTimeFormatter(10, 5);

            string format = timeFormatter.Format();

            Assert.AreEqual(format, "*/5");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionFormatTestMethod()
        {
            ICronFormatter timeFormatter = new EveryNTimeFormatter(2, 5);
        }
    }
}