using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_BeerTime
{
    class Program
    {
        static void Main()
        {
            DateTime startBeerTime = DateTime.Parse("01:00 PM");
            DateTime endBeerTime = DateTime.Parse("03:00 AM");
            Console.WriteLine("Enter time (hh:mm tt; e.g. 11:00 PM) ");
            string inputTime = Console.ReadLine();
            try
            {

                DateTime inputTimeParsed = DateTime.ParseExact(inputTime, "h:mm tt", CultureInfo.InvariantCulture);
                bool evening = inputTimeParsed.TimeOfDay.CompareTo(startBeerTime.TimeOfDay) >= 0;
                bool morning = inputTimeParsed.TimeOfDay.CompareTo(endBeerTime.TimeOfDay) < 0;
                if (evening || morning)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid time");
            }
        }
    }
}
