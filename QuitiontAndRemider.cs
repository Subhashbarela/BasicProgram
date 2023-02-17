using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoding
{
    internal class QuitiontAndRemider
    {
        public static void QuitiontReminder()
        {
            Console.Write("Entert the divident : ");
            double dividend=Convert.ToDouble(Console.ReadLine());
            Console.Write("Entert the divident : ");
            double divisor=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
           

            double quotient = dividend / divisor;
            double remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0}   Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);

        }
    }
}
