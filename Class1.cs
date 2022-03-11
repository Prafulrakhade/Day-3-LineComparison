using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisons
{
    public class Class1
    {
        double x1, y1, x2, y2;
        double distance;
        public void Length()
        {
            Console.WriteLine("Enter the Point 1 ( x1 , y1 : )");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Point 2 ( x2 , y2 : )");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            distance = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            Console.WriteLine("The Length Between Point 1 and Point 2 = " + distance);
        }

    }
}
