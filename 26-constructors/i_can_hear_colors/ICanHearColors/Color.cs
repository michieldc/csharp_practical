using System;
using System.Collections.Generic;
using System.Text;

namespace ICanHearColors
{
    public class Color
    {
        public Color()
        {
            this.red = 0;
            this.green = 0;
            this.blue = 0;
        }
        public  Color(int red, int green, int blue)
        {
            if (red < 0)
            {
                red = 0;
            }
            else if (red > 255)
            {
                red = 255;
            }

            this.red = red;

            if (blue < 0)
            {
                blue = 0;
            }
            else if (blue > 255)
            {
                blue = 255;
            }

            this.blue = blue;

            if (green < 0)
            {
                green = 0;
            }
            else if (green > 255)
            {
                green = 255;
            }

            this.green = green;

        }

        public int Red { 
            get
            {
                return this.red;
            }
            set
            {
                if (value < 0)
                {
                    this.red = 0;
                }
                else if (value > 255)
                {
                    this.red = 255;
                }
                else
                {
                    this.red = value;
                }
            }
         }

        public int Green { 
            get
            {
                return this.green;
            }
            set
            {
                if (value < 0)
                {
                    this.green = 0;
                }
                else if (value > 255)
                {
                    this.green = 255;
                }
                else
                {
                    this.green = value;
                }

            }
        }

        public int Blue { 
            get 
            { 
                return this.blue;
            } 
            set 
            {
                if (value < 0)
                {
                    this.blue = 0;
                }
                else if (value > 255)
                {
                    this.blue = 255;
                }
                else
                {
                    this.blue = value;
                }

            } 
        }

        public override string ToString()
        {
            return $"Red: {this.red} | Green: {this.green} | Blue: {this.blue}";
        }

        private int red = 0;
        private int green = 0;
        private int blue = 0;
    }
}
