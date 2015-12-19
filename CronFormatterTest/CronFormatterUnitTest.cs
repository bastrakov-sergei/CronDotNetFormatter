using CronDotNetFormatter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CronFormatterTest
{
    [TestClass]
    public class CronFormatterUnitTest
    {
        [TestMethod]
        public void CronFormatterTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.Format();

            Assert.AreEqual(format, "* * * * *");
        }

        [TestMethod]
        public void CronFormatterEveryMinuteTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.EveryMinute().Format();

            Assert.AreEqual(format, "* * * * *");
        }

        [TestMethod]
        public void CronFormatterEveryNMinuteTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.EveryNMinute(10).Format();

            Assert.AreEqual(format, "*/10 * * * *");
        }

        [TestMethod]
        public void CronFormatterEverySelectedMinuteTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.EverySelectedMinute(new[] {1, 2, 3}).Format();

            Assert.AreEqual(format, "1,2,3 * * * *");
        }


        [TestMethod]
        public void CronFormatterEveryHourTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.EveryHour().Format();

            Assert.AreEqual(format, "* * * * *");
        }

        [TestMethod]
        public void CronFormatterEveryNHourTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.EveryNHour(10).Format();

            Assert.AreEqual(format, "* */10 * * *");
        }

        [TestMethod]
        public void CronFormatterEverySelectedHourTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.EverySelectedHour(new[] { 1, 2, 3 }).Format();

            Assert.AreEqual(format, "* 1,2,3 * * *");
        }  

        [TestMethod]
        public void CronFormatterEveryDayOfMonthTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.EveryDayOfMonth().Format();

            Assert.AreEqual(format, "* * * * *");
        }                                      

        [TestMethod]
        public void CronFormatterEverySelectedDayOfMonthTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.EverySelectedDaysOfMonth(new[] { 1, 2, 3 }).Format();

            Assert.AreEqual(format, "* * 1,2,3 * *");
        } 

        [TestMethod]
        public void CronFormatterEveryMonthTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.EveryMonth().Format();

            Assert.AreEqual(format, "* * * * *");
        }  

        [TestMethod]
        public void CronFormatterEverySelectedMonthTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.EverySelectedMonths(new[] { 1, 2, 3 }).Format();

            Assert.AreEqual(format, "* * * 1,2,3 *");
        }        

        [TestMethod]
        public void CronFormatterEveryDayOfWeekTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.EveryDayOfWeek().Format();

            Assert.AreEqual(format, "* * * * *");
        }  

        [TestMethod]
        public void CronFormatterEverySelectedDayOfWeekTest()
        {
            ICronFluentFormatter formatter = new CronFormatter();
            string format = formatter.EverySelectedDaysOfWeek(new[] { 1, 2, 3 }).Format();

            Assert.AreEqual(format, "* * * * 1,2,3");
        }
    }
}
