using System;
using System.Collections.Generic;
using System.Text;

namespace SeriesOfSquares
{
    public class SquaredSeries
    {
        public static int SeriesSum(int n)
        {
            // TODO - Determine the sum of a squared series using a simple loop
            int sum = 0;
            for(int i = 0; i <= n;) {
                sum = sum + (i * i);
                i++;
            }
            return sum;
        }

        public static int CalculateSumSeries(int n)
        {
            // TODO - Determine the sum using the formula for a squared series
            return (n * (n + 1) * (2 * n + 1)) / 6; ;
        }
    }
}
