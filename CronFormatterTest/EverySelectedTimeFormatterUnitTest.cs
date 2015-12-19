using System;
using System.Collections.Generic;
using CronDotNetFormatter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CronFormatterTest
{
    [TestClass]
    public class EverySelectedTimeFormatterUnitTest
    {
        [TestMethod]
        public void FormatSingleSelectedTestMethod()
        {
            ICronFormatter timeFormatter = new EverySelectedTimeFormatter(10, 5);

            string format = timeFormatter.Format();

            Assert.AreEqual(format, "5");
        }

        [TestMethod]
        public void FormatMultipleSelectedTestMethod()
        {
            ICronFormatter timeFormatter = new EverySelectedTimeFormatter(10, new List<int> { 5, 6, 7 });

            string format = timeFormatter.Format();

            Assert.AreEqual(format, "5,6,7");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionFormatSingleSelectedTestMethod()
        {
            ICronFormatter timeFormatter = new EverySelectedTimeFormatter(2, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionFormatMultipleSelectedTestMethod()
        {
            ICronFormatter timeFormatter = new EverySelectedTimeFormatter(2, new List<int> { 5, 6, 7 });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullExceptionFormatMultipleSelectedTestMethod()
        {
            ICronFormatter timeFormatter = new EverySelectedTimeFormatter(2, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EmptyExceptionFormatMultipleSelectedTestMethod()
        {
            ICronFormatter timeFormatter = new EverySelectedTimeFormatter(2, new List<int>());
        }
    }
}