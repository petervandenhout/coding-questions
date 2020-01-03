using FluentAssertions;
using System;
using Xunit;

namespace CodingQuestions
{
    /// <summary>
    /// Exchange the first and last characters in a given string and return the new string.
    /// https://www.w3resource.com/csharp-exercises/basic-algo/csharp-basic-algorithm-exercises-7.php
    /// </summary>
    public static class Exercise7
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
            return str.Length > 1 ? $"{str[str.Length-1]}{str.Substring(1, str.Length-2)}{str[0]}" : str;
        }

        #endregion

        #region Tests

        public class Tests
        {
            [Theory]
            [InlineData("abcd", "dbca")]
            [InlineData("a", "a")]
            [InlineData("xy", "yx")]
            [InlineData("abc", "cba")]
            public void Test(string str, string expected)
            {
                var result = Compute(str);

                result.Should().Be(expected);
            }
        }

        #endregion
    }
}
