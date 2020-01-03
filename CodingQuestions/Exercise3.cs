using FluentAssertions;
using System;
using Xunit;

namespace CodingQuestions
{
    /// <summary>
    /// Check two given integers, and return true if one of them is 30 or if their sum is 30
    /// https://www.w3resource.com/csharp-exercises/basic-algo/csharp-basic-algorithm-exercises-3.php
    /// </summary>
    public static class Exercise3
    {
        public static bool Compute(int x, int y)
        {
            if (Constants.TestSolutions)
                return Solution(x, y);

            throw new NotImplementedException();
        }

        #region Solution

        private static bool Solution(int x, int y)
        {
            const int z = 30;
            return x == z || y == z || (x + y == z);
        }

        #endregion

        #region Tests

        public class Tests
        {
            [Theory]
            [InlineData(30, 0, true)]
            [InlineData(25, 5, true)]
            [InlineData(20, 30, true)]
            [InlineData(20, 25, false)]
            public void Test(int x, int y, bool expected)
            {
                var result = Compute(x, y);

                result.Should().Be(expected);
            }
        }

        #endregion
    }
}
