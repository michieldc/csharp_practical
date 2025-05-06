using System;
using System.Collections.Generic;
using System.Text;

namespace RoundAbout
{
    public class Circle
    {
        
        public void SetRadius(double radValue)
        {
            if(radValue < 0)
            {
                // do nothing
            }
            else
            {
                radius = radValue;
            }
        }

        public double GetRadius()
        {
            return radius;
        }

        public double GetDiameter()
        {
            return radius * 2;
        }

        public double CalculateArea()
        {
            return radius * radius * Math.PI;
        }

        public double CalculateCircumference()
        {
            return (2 * Math.PI) * radius;
        }

        public double radius = 0;
    }
}
