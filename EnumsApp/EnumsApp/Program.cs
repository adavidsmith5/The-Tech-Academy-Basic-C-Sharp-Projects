using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week.");
            string today = Console.ReadLine();
            today = today.First().ToString().ToUpper() + today.Substring(1);
            DayOfTheWeek day;

            try
            {
                day = (DayOfTheWeek)DayOfTheWeek.Parse(typeof(DayOfTheWeek),today);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.(all lowercase or first uppercase only please)");
            }

            

            Console.Read();
        }
    }

    public enum DayOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
