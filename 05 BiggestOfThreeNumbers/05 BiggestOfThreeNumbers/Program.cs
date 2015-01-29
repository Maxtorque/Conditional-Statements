using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BiggestOfThreeNumbers
{
    class Program
    {
        static void Main()
        {
            int a, b, c, biggestNumber;
            Console.Write("Enter the first number a:");
            bool isaInt = int.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter the second number b:");
            bool isbInt = int.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter the third number c:");
            bool iscInt = int.TryParse(Console.ReadLine(), out c);

            if (isaInt && isbInt && iscInt)
            {
                if (a > b)
                {
                    if (b > c)
                    {
                        biggestNumber = a;
                    }
                    else
                    {
                        if (c > a)
                        {
                            biggestNumber = c;
                        }
                        else
                        {
                            biggestNumber = a;
                        }

                    }

                }
                else
                {
                    if (a > c)
                    {
                        biggestNumber = b;
                    }
                    else
                    {
                        if (c > b)
                        {
                            biggestNumber = c;
                        }
                        else
                        {
                            biggestNumber = b;
                        }

                    }
                }
                Console.WriteLine("The biggest number={0}", biggestNumber);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the values are not integer!");
            }
        }
    }
}
