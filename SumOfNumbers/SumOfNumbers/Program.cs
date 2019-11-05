using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 1234;
            int sum = 0;

            //int myRightMostDigit = myNum % 10;
           // int myLeftMostDigit = myNum / 100;
           // int myMiddleDigit = (myNum / 10) % 10;


            

            while(myNum != 0)
            {
                int myTempNum = myNum % 10;
                sum += myTempNum;
                myNum /= 10;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
