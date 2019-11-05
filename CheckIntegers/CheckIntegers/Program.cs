using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            
            //Get input from user for int a 
            Console.WriteLine("Enter first Number");
            a = int.Parse(Console.ReadLine());

            //Get input from user for int b 
            Console.WriteLine("Enter Second Number");
            b = int.Parse(Console.ReadLine());

            //Displaying values of int a and b
            Console.WriteLine("Value of a {0}, Value of b {1}", a, b);

            //Method call returns true or false after performing check
            Console.WriteLine(CheckNumbers(a, b));
            Console.ReadKey();
        }

        public static Boolean CheckNumbers(int a, int b) {
            if((a >= 0 && b < 0) || (a < 0 && b >= 0)) {
                return true;
            }

            else {
                return false;
            }
        }
    }
}
