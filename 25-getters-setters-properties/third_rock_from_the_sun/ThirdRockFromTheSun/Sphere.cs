using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ThirdRockFromTheSun
{
    public class Sphere
    {
        public double Radius 
        { 
            get
            {
                return this.radius;
            }
            set 
            { 
                if (value <= 0)
                {
                    this.radius = Math.Abs(value);
                }
                else
                {
                    this.radius = value;
                }
            } 
        }

        public double Diameter 
        {
            get
            {
                return this.radius * 2;
            }
            set
            {
                if (value <= 0)
                {
                    this.radius = Math.Abs(value) / 2;
                }
                else
                {
                    this.radius = value / 2;
                }
            }
        }

        public double Volume()
        {
            return (4.0 / 3.0 * Math.PI * Math.Pow(this.radius, 3)); //Merk op de 4.0 en 3.0 - voor double division te doen en niet int division
        }

        public double Circumference()
        {
            return (2 * Math.PI * this.radius);
        }

        public double Surface()
        {
            return (4 * Math.PI ) * Math.Pow(this.radius, 2);
        }

        private double radius;
    }
}
