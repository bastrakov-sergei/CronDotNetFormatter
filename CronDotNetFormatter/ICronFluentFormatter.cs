namespace CronDotNetFormatter
{
    public interface ICronFluentFormatter : ICronFormatter
    {
        ICronFluentFormatter EveryMinute();
        ICronFluentFormatter EveryNMinute(int minute);
        ICronFluentFormatter EverySelectedMinute(int[] minutes);

        ICronFluentFormatter EveryHour();
        ICronFluentFormatter EveryNHour(int hour);
        ICronFluentFormatter EverySelectedHour(int[] hours);

        ICronFluentFormatter EveryDayOfMonth();
        ICronFluentFormatter EverySelectedDaysOfMonth(int[] daysOfMonth);

        ICronFluentFormatter EveryMonth();
        ICronFluentFormatter EverySelectedMonths(int[] months);

        ICronFluentFormatter EveryDayOfWeek();
        ICronFluentFormatter EverySelectedDaysOfWeek(int[] daysOfWeek);
    }
}