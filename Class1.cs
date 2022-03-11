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
        double length1, length2;
        public void Length()
        {
            Console.WriteLine("Enter the Line 1 ( x1 , y1 : )");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the line 2 ( x2 , y2 : )");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());

            distance = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            Console.WriteLine("The Length Between Line 1 and Line 2 = " + distance);
        }

        public void Equal()
        {
            Console.WriteLine("Check Point 1 And Point 2 Equal or Not");
            Console.WriteLine("Enter the Point 1 ( x1 , y1 : )");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Point 2 ( x2 , y2 : )");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());

            if (x1 == x2)
            {

                Console.WriteLine(y1.Equals(y2));
            }
            else
            {
                length1 = y1 - x1;
                length2 = y2 - x2;
                Console.WriteLine((length1).Equals(length2));
            }
        }
        public void Compare()
        {
            Console.WriteLine("Check Point 1 And Point 2 Equal or Not");
            Console.WriteLine("Enter the Point 1 ( x1 , y1 : )");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Point 2 ( x2 , y2 : )");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());

            if (x1 == x2)
            {

                double l = (y1.CompareTo(y2));
                if (l == 0)
                {
                    Console.WriteLine("Line 1 and Line 2 are Euqal");
                }
                else if (l > 0)
                {
                    Console.WriteLine("Line 1 is Greater");
                }
                else
                {
                    Console.WriteLine("Line 1 is Smaller");
                }
            }
            else
            {
                length1 = y1 - x1;
                length2 = y2 - x2;

                double d = (length1.CompareTo(length2));
                if (d == 0)
                {
                    Console.WriteLine("Both Line 1 and Line are Equal");
                }
                else if (d > 0)
                {
                    Console.WriteLine("Line 1 is Greater");
                }
                else
                {
                    Console.WriteLine("Line 1 is Small");
                }
            }
        }
    }
}
