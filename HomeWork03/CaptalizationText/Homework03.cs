using System;
using System.Collections.Generic;
using System.Linq;

namespace CaptalizationText
{
    public class Homework03 : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            return text.Select(it => it.ToUpper());
        }

    }
}
