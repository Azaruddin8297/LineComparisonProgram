using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    public class CartisanSystem
    {
        public static void method()
        {
            double x1 = 2.0;
            double y1 = 3.0;
            double x2 = 4.0;
            double y2 = 5.0;

            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of line is: " + length);
        }

    }
}
