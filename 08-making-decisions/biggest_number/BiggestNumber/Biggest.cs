﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BiggestNumber
{
    public class Biggest
    {
        public int DetermineBiggest(int first, int second, int third)
        {
            // TODO Determine the biggest number of the three
            
            int biggest = 0;

            if ((first >= second) && (first >= third))
            {
                biggest = first;
            }
            else if ((second >= first) && (second >= third))
            {
                biggest = second;
            }
            else if ((third >= first) && (third >= second))
            {
                biggest = third;
            }

            // Please dont change the code below (automatic unit tests)
            return biggest;
        }
    }
}
