using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparision
{
    public class LineComp
    {
        public void lc()
        {
            Console.Write("Enter any  value x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any  value y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double d1 = x1 - y1;
            double d2 = x2 - y2;

            int distance = d1.CompareTo(d2);
                 if (distance > 0)
                Console.WriteLine("line 1 is greater than line 2");
            else if (distance < 0)
                Console.WriteLine("line 1 is less than line 2");
            else
                Console.WriteLine("line 1 is equal to line 2");

                 Console.ReadKey();
        }
    }


} 
        

    

