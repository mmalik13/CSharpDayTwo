using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringContainsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "wtywqaz";
            int countWs = 0;

            foreach(char ch in str)
            {
                if(ch == 'w')
                {
                    countWs++;
                }
            }
            Console.WriteLine("number of Ws : {0}", countWs);
            Console.ReadKey();
        }
    }
}
