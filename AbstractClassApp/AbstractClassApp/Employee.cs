using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassApp
{
    public class Employee : Person, IQuittable
    {
        public int id;

        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("An employee has quit.");
        }

        public static bool operator == (Employee employee1, Employee employee2)
        {
            if(employee1.id == employee2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Employee employee1, Employee employee2)
        {
            if(employee1.id != employee2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
