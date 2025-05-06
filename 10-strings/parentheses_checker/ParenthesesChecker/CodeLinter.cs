using System;
using System.Collections.Generic;
using System.Text;

namespace ParenthesesChecker
{
    public class CodeLinter
    {
        public bool HasMatchingParentheses(string code)
        {
            bool isValid = true;
            int counter = 0;
            // TODO Determine if the code has matching parentheses

            // Please dont change the code below (automatic unit tests)
            for (int i = 0; i < code.Length; i++)
            {
                if ('(' == code[i])
                {
                    counter++;
                } else if (')' == code[i])
                {
                    counter--;
                    if(counter < 0)
                    {
                        isValid = false;
                        break;
                    }
                }

            }
            if (counter < 0 || counter > 0)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
