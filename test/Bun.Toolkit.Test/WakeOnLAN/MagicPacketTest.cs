using Bun.Toolkit.Extensions;
using System;
using System.Net.NetworkInformation;
using Xunit;

namespace Bun.Toolkit.Test.WakeOnLAN
{
    public class MagicPacketTest
    {
        [Fact]
        public void WhenPhysicalAddressIsNull_Throws_ArgumentNullException()
        {
            // Arrange
            PhysicalAddress address = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => address.Wake());
        }

        [Fact]
        public void ValidMacAddress_Success()
        {
            // Arrange
            var address = PhysicalAddress.Parse("11-22-33-44-55-66");

            // Act
            var isSuccessed = false;
            try
            {
                address.Wake();
                isSuccessed = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Assert
            Assert.True(isSuccessed);
        }
    }

}
