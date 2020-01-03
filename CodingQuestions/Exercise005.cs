using FluentAssertions;
using System;
using Xunit;

namespace CodingQuestions
{
    /// <summary>
    /// Create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged.
    /// https://www.w3resource.com/csharp-exercises/basic-algo/csharp-basic-algorithm-exercises-5.php
    /// </summary>
    public static class Exercise005
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

            return str.StartsWith("if", StringComparison.InvariantCultureIgnoreCase) ? str : $"if {str}";
        }

        #endregion

        #region Tests

        public class Tests
        {
            [Theory]
            [InlineData("if else", "if else")]
            [InlineData("else", "if else")]
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
