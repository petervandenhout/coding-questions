using FluentAssertions;
using System;
using Xunit;

namespace CodingQuestions
{
    /// <summary>
    /// Compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
    /// https://www.w3resource.com/csharp-exercises/basic-algo/csharp-basic-algorithm-exercises-1.php
    /// </summary>
    public static class Exercise1
    {
        public static int Compute(int x, int y)
        {
            if (Constants.TestSolutions)
                return Solution(x, y);

            throw new NotImplementedException();
        }

        #region Solution

        private static int Solution(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }

        #endregion

        #region Tests

        public class Tests
        {
            [Theory]
            [InlineData(1, 2, 3)]
            [InlineData(3, 2, 5)]
            [InlineData(2, 2, 12)]
            public void Test(int x, int y, int expected)
            {
                var result = Compute(x, y);

                result.Should().Be(expected);
            }
        }

        #endregion
    }
}
