using Bun.Toolkit.Net.Extensions;
using System.Net.NetworkInformation;

namespace Bun.Toolkit.Net.Samples.WakeOnLAN
{
    class Program
    {
        static void Main()
        {
            // Magic Packet Sample

            var macAddress = PhysicalAddress.Parse("11-22-33-44-55-66");
            macAddress.Wake();
        }
    }
}
