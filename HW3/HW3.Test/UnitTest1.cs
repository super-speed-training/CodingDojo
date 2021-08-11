using System;
using System.Collections.Generic;
using Xunit;

namespace HW3.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var text = new List<string> { "asdasd", "qweqwe", "test" };

            var sut = new Homework03();
            var actual = sut.CapitalizedText(text);

            var expected = new List<string> { "ASDASD", "QWEQWE", "TEST" };
            Assert.Equal(actual, expected);
        }
    }
}
