using Bun.Toolkit.Extensions;
using System.Net.NetworkInformation;

namespace Bun.Toolkit.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Magic Packet Sample

            var macAddress = PhysicalAddress.Parse("11-22-33-44-55-66");
            macAddress.Wake();
        }
    }
}
