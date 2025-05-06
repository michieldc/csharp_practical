using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelArrays
{
    public class ArrayHelper
    {
        public static int CountDifferentFrom(int[] elements, int value)
        {
            // TODO - Count how many elements differ from 'value'
            int differentCounter = 0;

            foreach (int element in elements) {
                if (element != value) {
                    differentCounter++;
                }
            }


            return differentCounter;
        }

        public static int[] SumByElements(int[] first, int[] second)
        {
            // TODO - Return new array that contains the sum of the elements in
            // 'first' and 'second'.
            int[] sumOfArrays = new int[first.Length];

            for(int i = 0; i < first.Length; i++)
            {
                sumOfArrays[i] = first[i] + second[i];
            }

            return sumOfArrays;
        }

        public static int[] DoubleInSize(int[] numbers)
        {
            // TODO - Return an array twice the size of numbers with
            // the data of 'numbers' stored in front. Initialize the other
            // elements to '0'
            int[] doubleSized = new int[numbers.Length *2];
            for (int i = 0; i < doubleSized.Length; i++)
            {
                if(i < numbers.Length) {
                    doubleSized[i] = numbers[i];
                }
                else
                {
                    doubleSized[i] = 0;
                }
            }
            return doubleSized;
        }
    }
}
