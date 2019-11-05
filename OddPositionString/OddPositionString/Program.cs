using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddPositionString
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "abcdefgh";
            String myNewString = "";

            for(int i = 0; i < str.Length; i++)
            {
                if(i % 2 != 0)
                {
                    myNewString += str[i];
                }
            }

            Console.WriteLine("Original String: " + str);
            Console.WriteLine("New String: " + myNewString);
            Console.ReadKey();
        }
    }
}
