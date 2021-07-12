using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExtensionsMethod
{
    public static class DateTimeExtensions
    {
        public static bool IsWeekEnd(this DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;
        }

        public static bool IsWeekDay(this DateTime value)
        {
            return !IsWeekEnd(value);
        }
    }
}
