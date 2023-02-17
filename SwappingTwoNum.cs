using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoding
{
    internal class SwappingTwoNum
    {
        public static void SwapingNum()
        {
            /* int a = 10;int b = 20;
             Console.WriteLine("Before Swapping A is : {0} , B number is : {1} ", a, b);
             int temp = 0;
             temp= a;    
             a = b;
             b = temp;
             Console.WriteLine("After Swapping A is : {0} , B number is : {1} ",a, b);
            */
            //.........................swap tje number without using third variable............
            Console.WriteLine("Swap the number without using third varable :");
            int a = 10; int b = 20;
            Console.WriteLine("Before Swapping A is : {0} , B number is : {1} ", a, b);
            a = a + b;  //10 + 20 = 30
            b = a - b; // 30 - 20 = 10
            a = a - b;  //30 - 10 = 20

            Console.WriteLine("After Swapping A is : {0} , B number is : {1} ", a, b);
        }
    }
}
