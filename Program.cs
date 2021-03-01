using System;
using System.Globalization;
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
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            try
            {
                Console.WriteLine("Please enter the current day of the week");
                string dayString = Console.ReadLine();
                
                dayString = textInfo.ToTitleCase(dayString);
                daysOfTheWeek day = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), dayString);
                
                
                Console.WriteLine(day.ToString());
                Console.WriteLine((int)day);
                Console.ReadLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week in english.");
                Console.ReadLine();
            }


        }
    }  
}
