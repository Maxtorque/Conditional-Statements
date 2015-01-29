using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BonusScore
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.Write("Enter a digit in the range of [1-9]:");
            bool isnInt = int.TryParse(Console.ReadLine(), out n);

            if (isnInt && n > 0 && n < 10)
            {
                switch (n)
                {
                    case (1): n = n * 10; break;
                    case (2): n = n * 10; break;
                    case (3): n = n * 10; break;
                    case (4): n = n * 100; break;
                    case (5): n = n * 100; break;
                    case (6): n = n * 100; break;
                    case (7): n = n * 1000; break;
                    case (8): n = n * 1000; break;
                    case (9): n = n * 1000; break;
                }
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
