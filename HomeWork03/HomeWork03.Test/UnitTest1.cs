using NUnit.Framework;
using System.Collections.Generic;

namespace HomeWork03.Test
{
    public class Tests
    {
        private IHomework03 hw3;
        
        [SetUp]
        public void Setup()
        {
            hw3 = new Homework03();
        }

        [Test]
        public void Test1()
        {
            var myStringEnum = new List<string> { "Hello world", "Practice makes perfect" };

            var expected = new List<string> { "HELLO WORLD", "PRACTICE MAKES PERFECT" };
            var result = hw3.CapitalizedText(myStringEnum);

            Assert.AreEqual(expected,result);
        }
    }
}