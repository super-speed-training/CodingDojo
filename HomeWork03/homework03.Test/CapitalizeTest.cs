using System;
using System.Collections.Generic;
using Xunit;

namespace homework03.Test
{
    public class CapitalizeTest
    {
        [Theory]
        [InlineData("Hello world","HELLO WORLD")]
        public void ToUpperText(string inputString, string expected)
        { 
            var input = inputString.Split(' ');
            var sut = new CapitalizeLogic();
            var result = sut.CapitalizedText(input);
            var expect = expected.Split(' ');
            Assert.Equal(expect,result);
        }
    }
}
