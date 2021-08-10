using System;
using upperlogic;

namespace testbug
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var text = new string[a];
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = Console.ReadLine();
            }
            var c = new Homework03Logic();
            var result = c.CapitalizedText(text);
            foreach (var item in result)
            {
            System.Console.WriteLine(item);
                
            }
        }
    }
}
