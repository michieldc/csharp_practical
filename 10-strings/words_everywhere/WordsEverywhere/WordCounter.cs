using System;
using System.Collections.Generic;
using System.Text;

namespace WordsEverywhere
{
    public class WordCounter
    {
        public int CountWords(string text)
        {
            int numberOfWords = 0;
            char[] delimiters = new char[] { ' ', '\r', '\n', '.', '!', ',', '?'};

            numberOfWords = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;

            return numberOfWords;
        }
    }
}
