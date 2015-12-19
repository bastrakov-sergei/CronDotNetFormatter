using System;

namespace CronDotNetFormatter
{
    public class EveryNTimeFormatter : ICronFormatter
    {
        private const string FormatString = "*/{0}";
        private readonly int value;

        public EveryNTimeFormatter(int limit, int value)
        {
            if (value >= limit)
            {
                throw new ArgumentOutOfRangeException("value");
            }

            this.value = value;
        }

        public string Format()
        {
            return string.Format(FormatString, value);
        }
    }
}