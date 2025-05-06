using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace HoloGram
{
    public class PangramChecker
    {
        public bool IsPangram(string text)
        {
            bool isAPangram = true;
            char letter = 'a';
            // TODO Check if text is a pangram and thereby contains all the letters of the alphabet
            // TODO Convert text to lowercase first
            text = text.ToLower();
            while(isAPangram && letter <= 'z') //zolang panagram true is en de letter kleiner of gelijk is aan z (alles erboven is niet meer een character)
            {
                if(text.IndexOf(letter) < 0) //we zoeken in de string op de letter. Als de character gekregen is krijgen we de positie anders -1
                {
                    isAPangram = false; // als het dus onder 0 is (-1) dan zetten we de Panagram op false.
                }
                letter++; //we doorlopen de letters door deze ++ te doen. a wordt b, b wordt c, ...
            }

            return isAPangram;
        }
    }
}
