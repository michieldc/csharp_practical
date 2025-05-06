using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbbreviateThis
{
    public class Abbreviator
    {
        public string Abbreviate(string text)
        {
            string letters = "";
            string[] words = text.Split(' ', ',');
            if (words.Contains(""))
            {

            }
            else
            {
                foreach (string word in words)
                {
                 letters += word.Substring(0, 1).ToUpper();
                }
            }
                
            // TODO Convert text to an abbreviation
            // TODO Make sure that the end result contains upper-case letters only
            // TODO If text is empty, than so should letters be
            //letters.ToUpper();


            return letters;
        }
    }
}
