using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timing
{
    internal class Program
    {
        static DateTime ToSeconds(int seconds)
        {
            return DateTime.Now.AddSeconds(seconds);
        }

        static DateTime ToMinutes(int minutes)
        {
            return DateTime.Now.AddMinutes(minutes);    
        }

        static DateTime ToHours(int hours) 
        { 
            return DateTime.Now.AddHours(hours);
        }

        static DateTime ToDays(int days)
        {
            return DateTime.Now.AddDays(days);
        }
        static void Main(string[] args)
        {

        }
    }
}
