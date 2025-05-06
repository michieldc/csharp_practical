using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point
    {
        public void Move(double x, double y)
        {
            this.x = x; 
            this.y = y;
        }
        public double x = 0;
        public double y = 0;
    }
}
