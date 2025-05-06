using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace NumberManipulator
{
    public class Manipulator
    {
        public static int Reverse(int value)
        {
            // TODO - Reverse the digits back to front

            
            int result = 0;
            while (value > 0)
            {
                result = result * 10 + value % 10;
                value /= 10;
            }
            return result;
  
        }

        public static int Complement(int value)
        {
            // TODO - Calculate the complement by subtracting each digit from '9'
            return -1;
        }

        public static int DigitSum(int value)
        {
            // TODO - Determine the sum of the individual digits
            return -1;
        }
    }
}
