using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace CodingQuestions
{
    /// <summary>
    /// Create a new string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string.
    /// https://www.w3resource.com/csharp-exercises/basic-algo/csharp-basic-algorithm-exercises-8.php
    /// </summary>
    public static class Exercise008
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

            const int repeat = 4;
            return str.Length > 1 ? string.Concat(Enumerable.Repeat(str.Substring(0, 2), repeat)) : str;
        }

        #endregion

        #region Tests

        public class Tests
        {
            [Theory]
            [InlineData("C Sharp", "C C C C ")]
            [InlineData("JS", "JSJSJSJS")]
            [InlineData("a", "a")]
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
