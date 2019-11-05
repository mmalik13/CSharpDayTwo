using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Console input for int a 
            Console.WriteLine("Enter 1st Number ");
            int a = Convert.ToInt16(Console.ReadLine());

            //Console input for int b
            Console.WriteLine("Enter 2nd Number ");
            int b = Convert.ToInt16(Console.ReadLine());

            //Writing to console int a and int b before swap
            Console.WriteLine("Value of a before swap: " + a);
            Console.WriteLine("Value of b before swap: " + b);

            //Method call to swap numbers with ref keyword
            SwapNumbers(ref a, ref b);

            //Writing to console int a and int b after swap
            Console.WriteLine("\nValue of a after swap: " + a);
            Console.WriteLine("Value of b after swap: " + b);
            Console.ReadKey();
        }

        public static void SwapNumbers(ref int a, ref int b)
        {
            int tempNum = 0;
            tempNum = a;
            a = b;
            b = tempNum;
        }
    }
}
