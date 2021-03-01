using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Program
    {
        enum daysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Sat,
            Sunday
        };

      

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week");

                Enum.TryParse(Console.ReadLine(), out daysOfTheWeek day);
                
                
                Console.WriteLine(day.ToString());
                Console.WriteLine((int)day);
                Console.ReadLine();

            }
            catch (Exception )
            {
                Console.WriteLine("Please enter an actual day of the week in english.");
                Console.ReadLine();
            }


        }
    }  
}
