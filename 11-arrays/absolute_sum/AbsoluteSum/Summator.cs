﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbsoluteSum
{
    public class Summator
    {
        public int Sum(int[] values)
        {
            int sum = 0;

            // TODO Determine the absolute sum of all the numbers in the values array
            // TODO If the array does not contain any values (Length is 0), the result should be 0
            foreach(int value in values) {
                if (values.Length == 0)
                {
                    sum = 0;
                }
                else if (value > 0)
                {
                    sum += value;
                }
                else if (value < 0) {
                    sum -= value;
                }
                
            }

            return sum;
        }
    }
}
