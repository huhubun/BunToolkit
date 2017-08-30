using System;
using System.Collections.Generic;
using System.Linq;
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

        [Theory]
        [InlineData(2017, 1, 1, 2017, 1, 1)]
        [InlineData(2017, 1, 1, 2017, 1, 4)]
        [InlineData(2017, 1, 4, 2017, 1, 1)]
        [InlineData(2017, 2, 1, 2017, 3, 1)]
        [InlineData(2017, 3, 1, 2017, 2, 1)]
        [InlineData(2017, 2, 1, 2017, 3, 15)]
        [InlineData(2017, 3, 15, 2017, 2, 1)]
        [InlineData(2016, 11, 11, 2017, 2, 22)]
        [InlineData(2017, 2, 22, 2016, 11, 11)]
        public void Days_Returns_Successfully(int beginDateYear, int beginDateMonth, int beginDateDay, int endDateYear, int endDateMonth, int endDateDay)
        {
            // Arrange
            var beginDate = new DateTime(beginDateYear, beginDateMonth, beginDateDay);
            var endDate = new DateTime(endDateYear, endDateMonth, endDateDay);

            // Act
            var result = EachDate(beginDate, endDate);

            // Assert
            Assert.Equal(Math.Abs((beginDate - endDate).Days) + 1, result.Count());
        }
    }
}
