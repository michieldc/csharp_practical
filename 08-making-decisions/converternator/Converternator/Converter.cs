﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Converternator
{
    public class Converter
    {
        public double PoundToKilogram(double pounds)
        {
            // TODO Convert pounds to kilograms
            double kilograms = 0;
            kilograms = (pounds / 2.20462);

            // Please dont change the code below (automatic unit tests)
            return kilograms;
        }

        public double KilogramToPound(double kilograms)
        {
            // TODO Convert kilograms to pounds
            double pounds = 0;
            pounds = (kilograms * 2.20462);

            // Please dont change the code below (automatic unit tests)
            return pounds;
        }

        public double MileToKilometer(double miles)
        {
            // TODO Convert miles to kilometers
            double kilometers = 0;
            kilometers = (miles * 1.60934);

            // Please dont change the code below (automatic unit tests)
            return kilometers;
        }

        public double KilometerToMile(double kilometers)
        {
            // TODO Convert kilometers to miles
            double miles = 0;
            miles = (kilometers / 1609 );

            // Please dont change the code below (automatic unit tests)
            return miles;
        }
    }
}
