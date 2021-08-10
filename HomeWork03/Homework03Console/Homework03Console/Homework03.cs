using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03Console
{
    public class Homework03 : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            var result = new List<string>();
            foreach (var item in text)
            {
                result.Add(item.ToUpper());
            }
            return result;
        }
    }
}
