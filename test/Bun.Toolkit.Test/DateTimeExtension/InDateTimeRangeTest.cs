using Bun.Toolkit.Extensions;
using System;
using Xunit;

namespace Bun.Toolkit.Test.DateTimeExtension
{
    public class InDateTimeRangeTest
    {
        [Fact]
        public void DateInStartDateAndEndDate_Returns_True()
        {
            // Arrange
            var date = new DateTime(2017, 1, 28);
            var start = new DateTime(2017, 1, 27);
            var end = new DateTime(2017, 2, 2);

            // Act
            var result = date.In(start, end);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void DateTimeInStartTimeAndEndTime_Returns_True()
        {
            // Arrange
            var dateTime = new DateTime(2017, 1, 28, 13, 20, 55);
            var startTime = new DateTime(2017, 1, 28, 13, 00, 00);
            var endTime = new DateTime(2017, 1, 28, 14, 00, 00);

            // Act
            var result = dateTime.In(startTime, endTime);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void DateLessThanStartDate_Returns_False()
        {
            // Arrange
            var date = new DateTime(2017, 1, 20);
            var start = new DateTime(2017, 1, 27);
            var end = new DateTime(2017, 2, 2);

            // Act
            var result = date.In(start, end);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void DateGreaterThanEndDate_Returns_False()
        {
            // Arrange
            var date = new DateTime(2017, 2, 5);
            var start = new DateTime(2017, 1, 27);
            var end = new DateTime(2017, 2, 2);

            // Act
            var result = date.In(start, end);

            // Assert
            Assert.False(result);
        }
    }
}
