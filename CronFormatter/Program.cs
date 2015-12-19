using System;
using CronDotNetFormatter;

namespace CronFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            ICronFluentFormatter formatter = new CronDotNetFormatter.CronFormatter();

            Console.WriteLine(formatter.EveryMinute().EveryNHour(2).EverySelectedDaysOfMonth(new []{1,2,3}).EveryMonth().EverySelectedDaysOfWeek(new []{3}));
            Console.Read();
        }
    }
}
