using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryNibble
{
    public class NumberSystemConverter
    {
        public string DecimalToBinary(int decimalValue)
        {
            // TODO Convert the decimal value to
            // binary string representation
            string binary = "";
            int value = decimalValue;
            while(decimalValue != 0)
            {
                if (decimalValue % 2 == 1)
                {
                    decimalValue = (decimalValue / 2);
                    binary = binary.Insert(0, "1");
                }
                else if (decimalValue % 2 == 0)
                {
                    decimalValue = decimalValue / 2;
                    binary = binary.Insert(0, "0");
                }
                else
                {
                    break;
                }
            }
            if (binary.Length < 8)
            {
                for (int i = binary.Length; i < 8; i++)
                {
                    binary = binary.Insert(0, "0");
                }
                
            }
            binary = binary.Insert(4, " ");
            Console.Write(binary);
            // Please dont change the code below (automatic unit tests)
            return binary;
        }
    }
}
