﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pythagoras
{
    public class RightHandTriangle
    {
        public double DetermineA(double b, double c)
        {
            // TODO: Calculate the a-side from the b- and c-side
            double a = Math.Sqrt((c * c) - (b * b));

            // Please dont change the code below (automatic unit tests)
            return a;
        }
        public double DetermineB(double a, double c)
        {
            // TODO: Calculate the b-side from the a- and c-side
            double b = Math.Sqrt((c * c) - (a * a));

            // Please dont change the code below (automatic unit tests)
            return b;
        }
        public double DetermineC(double a, double b)
        {
            // TODO: Calculate the c-side from the a- and b-side
            
            double c = Math.Sqrt((a * a)+(b * b));

            // Please dont change the code below (automatic unit tests)
            return c;
        }
    }
}
