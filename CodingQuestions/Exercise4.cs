using FluentAssertions;
using System;
using Xunit;

namespace CodingQuestions
{
    /// <summary>
    /// Check a given integer and return true if it is within 10 of 100 or 200
    /// https://www.w3resource.com/csharp-exercises/basic-algo/csharp-basic-algorithm-exercises-4.php
    /// </summary>
    public static class Exercise4
    {
        public static bool Compute(int x)
        {
            if (Constants.TestSolutions)
                return Solution(x);

            throw new NotImplementedException();
        }

        #region Solution

        private static bool Solution(int x)
        {
            const int range = 10;
            return Math.Abs(100 - x) <= range || Math.Abs(200 - x) <= range;
        }

        #endregion

        #region Tests

        public class Tests
        {
            [Theory]
            [InlineData(103, true)]
            [InlineData(90, true)]
            [InlineData(190, true)]
            [InlineData(89, false)]
            public void Test(int x, bool expected)
            {
                var result = Compute(x);

                result.Should().Be(expected);
            }
        }

        #endregion
    }
}
