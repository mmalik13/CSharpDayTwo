using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 1;

            while(startingNumber < 100)
            {
                if (startingNumber % 2 != 0)
                {
                    Console.WriteLine(startingNumber);
                }
                startingNumber++;
            }
            Console.ReadKey();
        }
    }
}
