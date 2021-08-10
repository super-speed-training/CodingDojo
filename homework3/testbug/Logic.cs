using System;
using System.Collections.Generic;
using System.Linq;

namespace upperlogic
{
    public class Homework03Logic : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            var result = text.Select(it => it.ToUpper());
            return result; 
        }
    }
}