using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoding
{
    internal class EvenOddProgram
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter the element to check is even or odd : ");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is Even Value");
            }
            else
            {
                Console.WriteLine(num + " is Odd Value");
            }

            /*................Findout Which elemement are even or odd.............

             Console.WriteLine("Enter the range : ");
              int result=Convert.ToInt32(Console.ReadLine());
              for(int i=1;i<result;i++)
              {
                  if (i % 2 == 0)
                  {
                      Console.WriteLine(i + " is Even Value");
                  }
                  else
                  {
                      Console.WriteLine(i + " is Odd Value");
                  }
              }
              */


            //...........................using Array .........................
            /* int[] values = { 1, 22, 13, 44, 52, 66, 71, 88, 99, 100 };

             foreach (var result in values)
             {
                 if (result % 2 == 0)
                 {
                     Console.WriteLine(result + " is Even Value");
                 }
                 else
                 {
                     Console.WriteLine(result + " is Odd Value");
                 }
             }*/
        }
    }
}
