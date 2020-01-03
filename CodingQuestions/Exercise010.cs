using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace CodingQuestions
{

    /// <summary>
    /// Check if a given positive number is a multiple of 3 or a multiple of 7.
    /// https://www.w3resource.com/csharp-exercises/basic-algo/csharp-basic-algorithm-exercises-10.php
    /// </summary>
    public static class Exercise010
    {
        public static bool Compute(int n)
        {
            if (Constants.TestSolutions)
                return Solution(n);

            throw new NotImplementedException();
        }

        #region Solution

        private static bool Solution(int n)
        {
            return n % 3 == 0 || n % 7 == 0;
        }

        #endregion

        #region Tests

        public class Tests
        {
            [Theory]
            [InlineData(3, true)]
            [InlineData(14, true)]
            [InlineData(12, true)]
            [InlineData(37, false)]
            public void Test(int n, bool expected)
            {
                var result = Compute(n);

                result.Should().Be(expected);
            }
        }

        #endregion
    }
}
