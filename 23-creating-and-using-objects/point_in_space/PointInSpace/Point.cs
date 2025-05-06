using System;
using System.Collections.Generic;
using System.Text;

namespace PointInSpace
{
    public class Point
    {
        public void SetX(int x) { 
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public override string ToString()
        {
            return $"[{x},{y}]";
        }

        public int x = 0;
        public int y = 0;
    }
}
