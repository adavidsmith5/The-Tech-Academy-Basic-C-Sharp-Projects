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
            Employee employee1 = new Employee();
            employee1.firstName = "Sample";
            employee1.lastName = "Student";
            employee1.id = 1;

            employee1.SayName();

            Employee employee2 = new Employee();
            employee2.firstName = "New";
            employee2.lastName = "Employee";
            employee2.id = 1;

            if(employee1 == employee2)
            {
                Console.WriteLine("These two are the same employees.");
            }
            else
            {
                Console.WriteLine("These are two different employees.");
            }

            IQuittable employee = new Employee();

            employee.Quit();

            Console.ReadLine();
        }
    }
}
