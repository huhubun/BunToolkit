using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Bun.Toolkit.Net.Extensions
{
    /// <summary>
    /// Wake-on-LAN extension methods 
    /// </summary>
    public static class WOL
    {
        public static void Wake(this PhysicalAddress address)
        {
            var magicPacketBytes = GetMagicPacketBytes(address);

            var client = new UdpClient();
            client.Connect(IPAddress.Broadcast, 0);
            client.Send(magicPacketBytes, magicPacketBytes.Length);
        }

        public static async void WakeAsync(this PhysicalAddress address)
        {
            var magicPacketBytes = GetMagicPacketBytes(address);

            var client = new UdpClient();
            client.Connect(IPAddress.Broadcast, 0);
            await client.SendAsync(magicPacketBytes, magicPacketBytes.Length);
        }

        private static byte[] GetMagicPacketBytes(PhysicalAddress address)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }

            var addressBytes = address.GetAddressBytes();

            // AMD Magic Packet
            // FF FF FF FF FF FF * 1
            // 11 22 33 44 55 66 * 16
            // 6个 FF，后跟16次目标的 Mac 地址

            var magicPacketBytes = new byte[17 * 6];
            for (int i = 0; i < 6; i++)
            {
                magicPacketBytes[i] = 0xFF;
            }

            for (int i = 1; i <= 16; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    magicPacketBytes[i * 6 + j] = addressBytes[j];
                }
            }

            return addressBytes;
        }
    }
}
