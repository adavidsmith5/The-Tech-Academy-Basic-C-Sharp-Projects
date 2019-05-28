using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            Console.WriteLine("Please provide a whole number.");
            int hours = Convert.ToInt16(Console.ReadLine());

            DateTime newTime = currentTime.AddHours(hours);

            Console.WriteLine("In {0} hours it will be:", hours);
            Console.WriteLine(newTime);

            Console.Read();
        }
    }
}
