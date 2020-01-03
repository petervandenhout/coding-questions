using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace CodingQuestions
{
    /// <summary>
    /// Remove the character in a given position of a given string. The given position will be in the range 0...string length -1 inclusive.
    /// https://www.w3resource.com/csharp-exercises/basic-algo/csharp-basic-algorithm-exercises-6.php
    /// </summary>
    public static class Exercise006
    {
        public static string Compute(string str, int n)
        {
            if (Constants.TestSolutions)
                return Solution(str, n);

            throw new NotImplementedException();
        }

        #region Solution

        private static string Solution(string str, int n)
        {
            if (string.IsNullOrEmpty(str)) return "";
            if (n >= str.Length - 1) return str;

            return str.Remove(n, 1);
        }

        #endregion

        #region Tests

        public class Tests
        {
            [Theory]
            [InlineData("Python", 1, "Pthon")]
            [InlineData("Python", 0, "ython")]
            [InlineData("Python", 4, "Pythn")]
            [InlineData("a", 1, "a")]
            [InlineData("", 1, "")]
            [InlineData(null, 1, "")]
            public void Test(string str, int n, string expected)
            {
                var result = Compute(str, n);

                result.Should().Be(expected);
            }
        }

        #endregion
    }
}
