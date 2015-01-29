using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BiggestOfFiveNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter e: ");
            double e = double.Parse(Console.ReadLine());

            if (a >= b && a >= c && a >= d && a >= e)
            {
                Console.WriteLine("Biggest :" + a);
            }
            else if (a <= b && b >= c && b >= d && b >= e)
            {
                Console.WriteLine("Biggest :" + b);
            }
            else if (c >= a && b <= c && c >= d && c >= e)
            {
                Console.WriteLine("Biggest :" + c);
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine("Biggest :" + d);
            }
            else if (e >= a && e >= b && e >= c && e >= d)
            {
                Console.WriteLine("Biggest :" + e);
            }
        }
    }
}
