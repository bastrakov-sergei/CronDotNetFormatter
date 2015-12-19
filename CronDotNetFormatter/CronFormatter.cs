namespace CronDotNetFormatter
{
    public class CronFormatter : ICronFluentFormatter
    {
        private const int MinuteLimit = 59;
        private const int HourLimit = 59;
        private const int DaysOfMonthLimit = 31;
        private const int MonthsLimit = 11;
        private const int DaysOfWeekLimit = 7;

        private ICronFormatter minuteFormatter = new EveryTimeFormatter();
        private ICronFormatter hourFormatter = new EveryTimeFormatter();
        private ICronFormatter dayOfMonthFormatter = new EveryTimeFormatter();
        private ICronFormatter monthFormatter = new EveryTimeFormatter();
        private ICronFormatter dayOfWeekFormatter = new EveryTimeFormatter();

        public string Format()
        {
            return string.Format("{0} {1} {2} {3} {4}",
                minuteFormatter.Format(),
                hourFormatter.Format(),
                dayOfMonthFormatter.Format(),
                monthFormatter.Format(),
                dayOfWeekFormatter.Format());
        }

        #region Minutes

        public ICronFluentFormatter EveryMinute()
        {
            minuteFormatter = new EveryTimeFormatter();
            return this;
        }

        public ICronFluentFormatter EveryNMinute(int minute)
        {
            minuteFormatter = new EveryNTimeFormatter(MinuteLimit, minute);
            return this;
        }

        public ICronFluentFormatter EverySelectedMinute(int[] minutes)
        {
            minuteFormatter = new EverySelectedTimeFormatter(MinuteLimit, minutes);
            return this;
        }

        #endregion

        #region Hours        

        public ICronFluentFormatter EveryHour()
        {
            hourFormatter = new EveryTimeFormatter();
            return this;
        }

        public ICronFluentFormatter EveryNHour(int hour)
        {
            hourFormatter = new EveryNTimeFormatter(HourLimit, hour);
            return this;
        }

        public ICronFluentFormatter EverySelectedHour(int[] hours)
        {
            hourFormatter = new EverySelectedTimeFormatter(HourLimit, hours);
            return this;
        }

        #endregion

        #region DayOfMonth 
        public ICronFluentFormatter EveryDayOfMonth()
        {
            dayOfMonthFormatter = new EveryTimeFormatter();
            return this;
        }

        public ICronFluentFormatter EverySelectedDaysOfMonth(int[] daysOfMonth)
        {
            dayOfMonthFormatter = new EverySelectedTimeFormatter(DaysOfMonthLimit, daysOfMonth);
            return this;
        }
        #endregion

        #region Month    
        public ICronFluentFormatter EveryMonth()
        {
            monthFormatter = new EveryTimeFormatter();
            return this;
        }

        public ICronFluentFormatter EverySelectedMonths(int[] months)
        {
            monthFormatter = new EverySelectedTimeFormatter(MonthsLimit, months);
            return this;
        }

        #endregion

        #region DayOfMonth      
        public ICronFluentFormatter EveryDayOfWeek()
        {
            dayOfWeekFormatter = new EveryTimeFormatter();
            return this;
        }

        public ICronFluentFormatter EverySelectedDaysOfWeek(int[] daysOfWeek)
        {
            dayOfWeekFormatter = new EverySelectedTimeFormatter(DaysOfWeekLimit, daysOfWeek);
            return this;
        }      
        #endregion

        public override string ToString()
        {
            return Format();
        }
    }
}