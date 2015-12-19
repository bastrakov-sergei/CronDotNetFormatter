using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CronDotNetFormatter
{
    public class EverySelectedTimeFormatter : ICronFormatter
    {
        private readonly IList<int> values;

        public EverySelectedTimeFormatter(int limit, IList<int> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values");
            }

            if (values.Count <= 0)
            {
                throw new ArgumentOutOfRangeException("values");
            }

            if (values.Any(minute => minute >= limit))
            {
                throw new ArgumentOutOfRangeException("values");
            }

            this.values = values;
        }

        public EverySelectedTimeFormatter(int limit, int value)
        {
            if (value >= limit)
            {
                throw new ArgumentOutOfRangeException("value");
            }

            values = new[] {value};
        }

        public string Format()
        {
            string formattedString = values.Select(i => i.ToString()).Aggregate((s1, s2) =>
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(
                    "{0},{1}", s1, s2);
                return sb.ToString();
            });
            return formattedString;
        }
    }
}