using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SortThreeNumbersNestedLfs
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
            if (a == b && b == c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else
            {
                if (a > b && a > c && b > c)
                {
                    Console.WriteLine("{0}>{1}>{2}", a, b, c);
                }
                else if (a > b && a > c && b < c)
                {
                    Console.WriteLine("{0}>{1}>{2}", a, c, b);
                }
                else if (b > a && a > c && b > c)
                {
                    Console.WriteLine("{0}>{1}>{2}", b, a, c);
                }
                else if (b > c && c > a && b > c)
                {
                    Console.WriteLine("{0}>{1}>{2}", b, c, a);
                }
                else if (c > a && a > b && c > b)
                {
                    Console.WriteLine("{0}>{1}>{2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0}>{1}>{2}", c, b, a);
                }
            }
        }
    }
}
