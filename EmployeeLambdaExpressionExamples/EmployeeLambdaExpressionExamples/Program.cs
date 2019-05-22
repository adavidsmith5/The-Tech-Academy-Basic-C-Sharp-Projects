using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLambdaExpressionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee();
            emp1.firstName = "Joe";
            emp1.lastName = "Thomas";
            emp1.id = 1;
            employees.Add(emp1);

            Employee emp2 = new Employee();
            emp2.firstName = "Charles";
            emp2.lastName = "Jones";
            emp2.id = 2;
            employees.Add(emp2);

            Employee emp3 = new Employee();
            emp3.firstName = "Alice";
            emp3.lastName = "Williams";
            emp3.id = 3;
            employees.Add(emp3);

            Employee emp4 = new Employee();
            emp4.firstName = "Joe";
            emp4.lastName = "Baremius";
            emp4.id = 4;
            employees.Add(emp4);

            Employee emp5 = new Employee();
            emp5.firstName = "Carol";
            emp5.lastName = "Branch";
            emp5.id = 5;
            employees.Add(emp5);

            Employee emp6 = new Employee();
            emp6.firstName = "Karl";
            emp6.lastName = "Marx";
            emp6.id = 6;
            employees.Add(emp6);

            Employee emp7 = new Employee();
            emp7.firstName = "Barry";
            emp7.lastName = "Manilow";
            emp7.id = 7;
            employees.Add(emp7);

            Employee emp8 = new Employee();
            emp8.firstName = "Susan";
            emp8.lastName = "Anthony";
            emp8.id = 8;
            employees.Add(emp8);

            Employee emp9 = new Employee();
            emp9.firstName = "Belvia";
            emp9.lastName = "Karlsson";
            emp9.id = 9;
            employees.Add(emp9);

            Employee emp10 = new Employee();
            emp10.firstName = "Joe";
            emp10.lastName = "Little";
            emp10.id = 10;
            employees.Add(emp10);

            List<Employee> joes = new List<Employee>();


            //foreach(Employee employee in employees)
            //{
            //    if(employee.firstName == "Joe")
            //    {
            //        joes.Add(employee);
            //    }
            //}


            //joes = employees.Where(x => x.firstName == "Joe").ToList();


            joes = employees.Where(x => x.id > 5).ToList();

            foreach (Employee employee in joes)
            {
                Console.WriteLine(employee.lastName);
            }



            Console.Read();
        }
    }
}
