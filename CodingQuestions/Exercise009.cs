using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace CodingQuestions
{
    /// <summary>
    /// Create a new string with the last char added at the front and back of a given string of length 1 or more.
    /// https://www.w3resource.com/csharp-exercises/basic-algo/csharp-basic-algorithm-exercises-9.php
    /// </summary>
    public static class Exercise009
    {
        public static string Compute(string str)
        {
            if (Constants.TestSolutions)
                return Solution(str);

            throw new NotImplementedException();
        }

        #region Solution

        private static string Solution(string str)
        {
            if (string.IsNullOrEmpty(str)) return "";

            return $"{str[str.Length - 1]}{str}{str[str.Length - 1]}";
        }

        #endregion

        #region Tests

        public class Tests
        {
            [Theory]
            [InlineData("Red", "dRedd")]
            [InlineData("Green", "nGreenn")]
            [InlineData("1", "111")]
            [InlineData("", "")]
            [InlineData(null, "")]
            public void Test(string str, string expected)
            {
                var result = Compute(str);

                result.Should().Be(expected);
            }
        }

        #endregion
    }
}
