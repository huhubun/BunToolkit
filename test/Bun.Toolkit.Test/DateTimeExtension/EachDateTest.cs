using System;
using System.Collections.Generic;
using Xunit;
using static Bun.Toolkit.DateTimeHelper;

namespace Bun.Toolkit.Test.DateTimeExtension
{
    public class EachDateTest
    {
        [Fact]
        public void EachDate_Returns_DateTimeCollection()
        {
            // Arrange
            var beginDate = new DateTime(2017, 1, 1);
            var endDate = new DateTime(2017, 1, 4);

            // Act
            var result = EachDate(beginDate, endDate);

            // Assert
            var expectedResult = new List<DateTime>
            {
                new DateTime(2017, 1, 1),
                new DateTime(2017, 1, 2),
                new DateTime(2017, 1, 3),
                new DateTime(2017, 1, 4)
            };

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void EachDateButBeginDateLessThanEndDate_Returns_DateTimeCollectionASC()
        {
            // Arrange
            var beginDate = new DateTime(2017, 1, 4);
            var endDate = new DateTime(2017, 1, 1);

            // Act
            var result = EachDate(beginDate, endDate);

            // Assert
            var expectedResult = new List<DateTime>
            {
                new DateTime(2017, 1, 1),
                new DateTime(2017, 1, 2),
                new DateTime(2017, 1, 3),
                new DateTime(2017, 1, 4)
            };

            Assert.Equal(expectedResult, result);
        }
    }
}
