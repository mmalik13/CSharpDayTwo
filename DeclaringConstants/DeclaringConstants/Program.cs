using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{

    class Demo
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;

            double r;

            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi * r * r;

            Console.WriteLine("Radius : {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();

            int a = 10;
            Demo d = new Demo();
            Type t = typeof(Demo);
            Console.WriteLine(sizeof(int));
            Console.WriteLine(d is Demo);
            Console.ReadLine();
        }
    }
}
