using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiggestOfThemAll
{
    public class ArrayAnalyzer
    {
        public int BiggestValue(int[] values)
        {
            int biggest = 0;

            // TODO Determine the biggest value in the array and place the result in biggest
            // Return 0 if the array is empty (Length == 0)

            for(int i = 0; i < values.Length; i++) {
                if(values.Length == 0)
                {
                    biggest = 0;
                }
                if (values[i] > biggest)
                {
                    biggest = values[i];
                }
            }


            // Please don't change the code below (automatic unit tests)
            return biggest;
        }

        public int BiggestIndex(int[] values)
        {
            int indexBiggest = -1;
            int biggestNumber = 0;

            // TODO Determine the index of the biggest value in the array
            // Place the resulting index in indexBiggest
            // Return -1 if the array is empty (Length == 0)
            // If multiple values exist, keep the first
            for (int i = 0; i < values.Length; i++)
            {
                if(values.Length == 0)
                {
                    indexBiggest = -1;
                }
                if (values[i] == biggestNumber)
                {
                    biggestNumber = values[i];
                } else if (values[i] > biggestNumber)
                {
                    indexBiggest = i;
                    biggestNumber = values[i];
                }

            }


            // Please don't change the code below (automatic unit tests)
            return indexBiggest;
        }
    }
}
