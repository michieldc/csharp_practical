using System;
using System.Collections.Generic;
using System.Text;

namespace Reversal
{
    public class StringReverser
    {
        public string Reverse(string text)
        {
            string reversed = "";

            for(int i = text.Length-1; i >= 0; i--)
            {
                reversed += text[i];
            }
            return reversed;
        }
    }
}
