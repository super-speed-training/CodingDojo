using System;
using System.Linq;
using System.Collections.Generic;

namespace homework03
{
    public class CapitalizeLogic : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            var Capitalize = text.ToArray();
            for (int i = 0; i < Capitalize.Length; i++)
            {
                Capitalize[i] = Capitalize[i].ToUpper();
            }
            return Capitalize;
        }
    }
}
