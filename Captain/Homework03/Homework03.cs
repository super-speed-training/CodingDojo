using System.Collections.Generic;
using System.Linq;

namespace Homework03
{
    public class Homework03 : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text) => text.Select(it => it.ToUpper());
    }
}
