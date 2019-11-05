using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int c = 2;

            MultiplyNumbers(a, b, c);
        }

        public static void MultiplyNumbers(int a, int b, int c)
        {
            int total = a * b * c;
            Console.WriteLine("Multiplication of " + a + " * " + b + " * " + c);
            Console.WriteLine("Result: " + total);
            Console.ReadKey();
        }
    }
}
