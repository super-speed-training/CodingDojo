using System;

namespace Homework03Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var sut = new Homework03();

            var list = new string[] { "Hello world", "Practice makes perfect" };
            var result = sut.CapitalizedText(list);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
