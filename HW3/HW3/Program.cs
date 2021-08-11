using System;
using System.Collections.Generic;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new List<string> { "Hello world", "Practice makes perfect" };

            Console.WriteLine("INPUTS:");
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }

            IHomework03 engines = new Homework03();
            var result = engines.CapitalizedText(text);

            Console.WriteLine("\n\nRESULT:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
