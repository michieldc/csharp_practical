using System;
using System.Collections.Generic;
using System.Text;

namespace ReplacePerformance
{
    public class StringHelper
    {
        public string ReplaceUsingLibrary(string text, string word, string replacement)
        {
            string alteredText = "";

            // TODO Use the string Replace method to replace all the occurences of word
            // with replacement inside of the string text;
            alteredText = text.Replace(word, replacement);

            return alteredText;
        }
        
        public string ReplaceUsingOwnImplementation(string text, string word, string replacement)
        {
            string alteredText = "";

            // TODO Do the same as the other method but don't use the Replace method.
            // Build your own implementation.
            int index = 0;
            string[] textArray = text.Split();
            
                foreach (string str in textArray)
                {
                    if (str == word)
                    {
                        alteredText = alteredText + replacement + " ";
                    }
                    else
                    {
                        alteredText = alteredText + str + " ";
                    }
                    index++;
                
                }
            return alteredText;
        }
    }
}
