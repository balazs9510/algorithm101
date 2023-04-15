using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Algorithms
{
    public class Recursion
    {
        public string StripZeros(string text)
        {
            if (text[0] == '0')
            {
                return StripZeros(text.Substring(1));
            }

            return text;
        }
    }
}
