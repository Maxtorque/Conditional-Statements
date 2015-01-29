using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ExchangeIfGreater
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            Console.Write("Enter the first number a:");
            bool isaInt = int.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter the second number b:");
            bool isbInt = int.TryParse(Console.ReadLine(), out b);

            if (isaInt && isbInt)
            {
                if (a > b)
                {
                    c = a;
                    a = b;
                    b = c;
                }
                Console.WriteLine("a={0}", a);
                Console.WriteLine("b={0}", b);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the values are not integer!");
            }
        }
    }
}
