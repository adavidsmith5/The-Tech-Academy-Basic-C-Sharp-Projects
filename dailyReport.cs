﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAStudentDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            byte pageNum = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            byte hoursOfStudy = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.Read();
        }
    }
}
