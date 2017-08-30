using Bun.Toolkit.Extensions;
using System;
using System.Net.NetworkInformation;
using Bun.Toolkit;
using System.Linq;

namespace Bun.Toolkit.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Network Sample

            // Magic Packet Sample

            var macAddress = PhysicalAddress.Parse("11-22-33-44-55-66");
            macAddress.Wake();

            #endregion


            #region DateTime Sample

            // In()
            var birthday = new DateTime(2017, 2, 22);
            if (birthday.In(new DateTime(2017, 2, 19), new DateTime(2017, 3, 20)))
            {
                Console.WriteLine("Pisces");
            }

            // EachDate()
            var allTheMonday = DateTimeHelper.EachDate(new DateTime(2017, 1, 1), new DateTime(2017, 1, 31))
                                             .Where(d => d.DayOfWeek == DayOfWeek.Monday);

            #endregion

        }
    }
}
