using FluentAssertions;
using System;
using Xunit;

namespace CodingQuestions
{
    /// <summary>
    /// Get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.
    /// https://www.w3resource.com/csharp-exercises/basic-algo/csharp-basic-algorithm-exercises-2.php
    /// </summary>
    public static class Exercise002
    {
        public static int Compute(int n)
        {
            if (Constants.TestSolutions)
                return Solution(n);

            throw new NotImplementedException();
        }

        #region Solution

        private static int Solution(int n)
        {
            const int x = 51;
            return n > x ? (n - x) * 3 : x - n;
        }

        #endregion

        #region Tests

        public class Tests
        {
            [Theory]
            [InlineData(53, 6)]
            [InlineData(30, 21)]
            [InlineData(51, 0)]
            public void Test(int n, int expected)
            {
                var result = Compute(n);

                result.Should().Be(expected);
            }
        }

        #endregion
    }
}
