using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate: ");
            double person1Rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the hours that you work per week: ");
            byte person1Hours = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate: ");
            double person2Rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the hours that you work per week: ");
            byte person2Hours = Convert.ToByte(Console.ReadLine());

            double annualSalaryPerson1 = person1Rate * person1Hours * 52;
            double annualSalaryPerson2 = person1Rate * person2Hours * 52;
            bool personOneMakesMore = annualSalaryPerson1 > annualSalaryPerson2;

            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(annualSalaryPerson1);
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(annualSalaryPerson2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(personOneMakesMore);



            Console.Read();
        }
    }
}
