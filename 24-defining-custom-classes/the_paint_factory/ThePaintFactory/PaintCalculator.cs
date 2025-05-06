using System;
using System.Collections.Generic;
using System.Text;

namespace ThePaintFactory
{
    public class PaintCalculator
    {
        public void AddSquare(double side)
        {
            this.totalArea += (side * side);
        }

        public void AddRectangle(double width, double height)
        {
            this.totalArea += (width * height);
        }

        public double LitersOfPaint(int coats)
        {
            double litersOfPaint = ((this.totalArea / 12) * coats); //Calculating how many liters of paint are required for the area
            litersOfPaint += (litersOfPaint / 100) * 5; // Adding the 5% extra calulation to the variable
            return Math.Ceiling(litersOfPaint); //returning the variable
        }

        // Attribute for total area to paint
        private double totalArea = 0;

        // Property for totalArea
        public double TotalArea { get { return totalArea; } }
    }
}
