using System;
using System.Collections.Generic;

namespace Bun.Toolkit
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// Returns each day between startDate and endDate.
        /// </summary>
        /// <param name="startDate">Start date</param>
        /// <param name="endDate">End date</param>
        /// <returns>From startDate to endDate every day(include startDate and endDate).</returns>
        public static IEnumerable<DateTime> EachDate(DateTime startDate, DateTime endDate)
        {
            var tmpDate = endDate;
            if (endDate < startDate)
            {
                endDate = startDate;
                startDate = tmpDate;
            }

            tmpDate = startDate;

            yield return tmpDate;

            while (true)
            {
                tmpDate = tmpDate.AddDays(1);

                if (tmpDate <= endDate)
                {
                    yield return tmpDate;
                }
                else
                {
                    yield break;
                }
            }
        }
    }
}
