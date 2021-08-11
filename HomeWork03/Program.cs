using System;
using System.Linq;

namespace HomeWork03
{
    class Program
    {
        static void Main(string[] args)
        {
            var txtEngine = new TextEngine();
            var upperText = txtEngine.UpperText("Practice makes perfect");
            Console.WriteLine(upperText);
        }
    }
    
    class TextEngine{
        public string UpperText(string text){
            return text.ToUpper();
        }
    }
}
