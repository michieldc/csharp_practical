using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextProperties
{
    public class StringAnalyzer
    {
        public int NumberOfVowels(string text)
        {
            int numberOfVowels = 0;
            string vowels = "aeiou";
            
            // TODO Count the number of vowels inside of text
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < vowels.Length ; j++)
                {
                    if (text.ToLower()[i] == vowels[j])
                    {
                        numberOfVowels++;
                    }
                }
            }

            return numberOfVowels;
        }

        public int NumberOfConsonants(string text)
        {
            int numberOfConsonants = 0;
            string consonants = "qwrtypsdfghjklzxcvbnm";

            // TODO Count the number of consonants inside of text
            for(int i = 0; i < text.Length; i++) // we overlopen iedere letter in de text. beginnende bij 0 naar text length.
            {
                for(int j = 0; j < consonants.Length; j++) // we overlopen iedere letter in de consonants beginnende bij positie 0
                {
                    if (text.ToLower()[i] == consonants[j]) //we kijken of de positie in de text gelijk is aan een letter in de consonants.
                    {
                        numberOfConsonants++; // als de consonant erin zit doen we een +1
                    }
                }
            }


            return numberOfConsonants;
        }

        public int NumberOfDigits(string text)
        {
            int numberOfDigits = 0;
            string digits = "1234567890";

            // TODO Count the number of digits inside of text
            for(int i = 0; i < text.Length; i++)
            {
                for(int j = 0; j < digits.Length; j++)
                {
                    if (text.ToLower()[i] == digits[j])
                    {
                        numberOfDigits++;
                    }
                }
            }

            return numberOfDigits;
        }

        public int NumberOfUppercaseLetters(string text)
        {
            int numberOfUppercaseLetters = 0;
            string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // TODO Count the number of upper case letters inside of text
            for(int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < uppercaseLetters.Length; j++)
                {
                    if(text[i] == uppercaseLetters[j]){
                        numberOfUppercaseLetters++;
                    }
                }
            }

            return numberOfUppercaseLetters;
        }

        public int NumberOfLowercaseLetters(string text)
        {
            int numberOfLowercaseLetters = 0;
            string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";

            // TODO Count the number of lower case letters inside of text
            for(int i = 0; i < text.Length; i++)
            {
                for(int j = 0; j < lowercaseLetters.Length; j++)
                {
                    if (text[i] == lowercaseLetters[j])
                    {
                        numberOfLowercaseLetters++;
                    }
                }
            }


            return numberOfLowercaseLetters;
        }

        public int NumberOfWhitespaceCharacters(string text)
        {
            int numberOfWhitespaceCharacters = 0;
            string whitespace = " \r\t\b\n\'\\\"";
            // TODO Count the number of whitespace characters inside of text
            for (int i = 0; i < text.Length; i++)
            {
                for(int j = 0; j < whitespace.Length; j++) 
                if (text[i] == whitespace[j])
                {
                    numberOfWhitespaceCharacters++;
                }
            }
            return numberOfWhitespaceCharacters;
        }
    }
}
