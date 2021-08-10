using FluentAssertions;
using Homework03;
using System.Collections.Generic;
using Xunit;

namespace HomeworkXUnit
{
    public class Homework03UnitTest
    {
        private IHomework03 IHW;
        public Homework03UnitTest() => IHW = new Homework03.Homework03();

        [Theory]
        [MemberData(nameof(GetCapitalizedTextCases))]
        public void CapitalizedTextShouldWork(IEnumerable<string> text, IEnumerable<string> expected)
        {
            var result = IHW.CapitalizedText(text);
            result.Should().BeEquivalentTo(expected);
        }

        public static IEnumerable<object[]> GetCapitalizedTextCases = new List<object[]>
        {
            new object[] {
                new string[] { "Hello world", "Practice makes perfect" } ,
                new string[] { "HELLO WORLD", "PRACTICE MAKES PERFECT" }
            }
        };
    }
}
