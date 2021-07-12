using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExtensionsMethod
{
    public static class DateTimeHelper
    {
        public static bool IsWeekEnd(DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;
        }

        public static bool IsWeekDay(DateTime value)
        {
            return !IsWeekEnd(value);
        }
    }
}
