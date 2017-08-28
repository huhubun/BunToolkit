using System;

namespace Bun.Toolkit.Extensions
{
    public static class DateTimeExtension
    {
        /// <summary>
        /// Determines whether a DateTime is in start and end DateTime (start &lt;= dateTime &lt;= end).
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static bool In(this DateTime dateTime, DateTime start, DateTime end)
        {
            return start <= dateTime && dateTime <= end;
        }
    }
}
