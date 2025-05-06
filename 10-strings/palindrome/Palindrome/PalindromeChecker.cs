using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string word)
        {
            bool isPalindrome = false;

            // TODO Determine if word is a palindrome
            string lowercase = word.ToLower().Trim();
            string reverse = "";
            for (int i = lowercase.Length-1; i >= 0; i--)
            {
                reverse += lowercase[i];
            }

            if (reverse == lowercase)
            {
                isPalindrome = true;
                if (lowercase.Equals(""))
                {
                    isPalindrome = false;
                }
            }
            else
            {
                isPalindrome = false;
            }

                // Please dont change the code below (automatic unit tests)
                return isPalindrome;
        }
    }
}
