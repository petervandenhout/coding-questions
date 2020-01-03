using FluentAssertions;
using System;
using Xunit;

namespace CodingQuestions
{
    /// <summary>
    /// Create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged.
    /// https://www.w3resource.com/csharp-exercises/basic-algo/csharp-basic-algorithm-exercises-5.php
    /// </summary>
    public static class Exercise5
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
            return str.StartsWith("if", StringComparison.InvariantCultureIgnoreCase) ? str : $"if {str}";
        }

        #endregion
    }

    public class Exercise5Tests
    {
        [Theory]
        [InlineData("if else", "if else")]
        [InlineData("else", "if else")]
        public void Test(string str, string expected)
        {
            var result = Exercise5.Compute(str);

            result.Should().Be(expected);
        }
    }
}
