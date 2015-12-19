namespace CronDotNetFormatter
{
    public class EveryTimeFormatter : ICronFormatter
    {
        private const string FormatString = "*";
        public string Format()
        {
            return FormatString;
        }
    }
}