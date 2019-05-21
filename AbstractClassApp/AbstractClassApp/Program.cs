using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>();
            employee1.firstName = "Sample";
            employee1.lastName = "Student";
            employee1.id = 1;
            employee1.Things.Add("Job: Programmer");
            employee1.Things.Add("Salary: $80,000");
            employee1.Things.Add("Date Hired: 05/19/2019");

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>();
            employee2.firstName = "New";
            employee2.lastName = "Employee";
            employee2.id = 1;
            employee2.Things.Add(5);
            employee2.Things.Add(6);
            employee2.Things.Add(7);

            foreach (String thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }



            //employee1.SayName();

            

            //if(employee1 == employee2)
            //{
            //    Console.WriteLine("These two are the same employees.");
            //}
            //else
            //{
            //    Console.WriteLine("These are two different employees.");
            //}

            //IQuittable employee = new Employee();

            //employee.Quit();

            Console.ReadLine();
        }
    }
}
