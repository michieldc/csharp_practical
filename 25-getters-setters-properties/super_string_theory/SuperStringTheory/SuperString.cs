using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;

namespace SuperStringTheory
{
    public class SuperString
    {
        // Text getter method
        // TODO - Replace with property
        public string Text { 
            get { return text; } 
            set {
                if (value == null) {
                    text = "";
                }
                else { text = value; 
                }
            }
           
        }


        public void Append(string text)
        {
            this.text += text;
        }


        // TODO - Add a Prepend() method
        public void Prepend(string text)
        {
            int fullLength = text.Length + this.text.Length;
            Console.WriteLine(fullLength);
            char[] fullText = new char[fullLength];
            for (int i = 0; i < text.Length; i++)
            {
                fullText[i] = text[i];
            }

            Console.WriteLine(fullText);
            int index = 0;
            for(int j = text.Length; j < fullLength; j++)
            {
                fullText[j] = this.text[index];
                index++;
            }

            this.text = new string(fullText);

        }

        public bool IsValidNumber()
        {
            if(text == "")
            {
               return false;
            }
            foreach (char c in text)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
                   return true;
        }

        public void TrimStart()
        {
            // TODO - Remove any spaces at the beginning of text.
            string trimmedText = "";
            bool foundWhitespaceCharacter = false;
            for (int i = 0; i < text.Length;i++ ) {
                if (text[i] == ' ')
                {
                    // do nothing
                }
                else
                {
                    foundWhitespaceCharacter = true;
                }

                if (foundWhitespaceCharacter)
                {
                    trimmedText += text[i];
                }
            }
            this.text = trimmedText;
        }

        // TODO - Add a TrimEnd() method
        public void TrimEnd()
        {
            int index = text.Length - 1; // we creëren een variabel om te loopen door de string
            while (index >= 0 && text[index] == ' ') //zolang de variabel >= 0 en een spatie is decrementeren we
            {
                index--;
            }
            char[] stringArray = new char[index + 1];
            for (int i = 0; i <= index; i++) {
                stringArray[i] = text[i];
            }
            this.text = new string(stringArray);
        }

        // TODO - Add a Trim() method

        public void Trim()
        {
            if (this.text == null)
            {
                //do nothing
            }
            else 
            {
                text = text.TrimStart();
                text = text.TrimEnd();
            }
                
        }

        // Attributes
        private string text = "";
    }
}
