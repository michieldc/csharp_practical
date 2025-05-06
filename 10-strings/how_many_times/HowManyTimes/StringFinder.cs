using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace HowManyTimes
{
    public class StringFinder
    {
        public int SearchAndCount(string text, string word)
        {
            int numberOfOccurrences = 0;

            string[] wordlist = text.ToLower().Split(' ', '.', '!', '\n', '\r');
            // TODO Count the number of times the word occurs in the text
            for (int i = 0; i < wordlist.Length; i++)
            {
                if(word == ""){
                    break;
                }
                if (wordlist[i] == word.ToLower())
                    {
                        numberOfOccurrences++;
                    }
            }
            // Please dont change the code below (automatic unit tests)
            return numberOfOccurrences;
        }
    }
}
