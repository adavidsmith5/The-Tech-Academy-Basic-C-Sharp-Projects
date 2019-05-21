using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassApp
{
    public class Employee<T> : Person, IQuittable
    {
        public int id;
        public List<T> Things { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("An employee has quit.");
        }

        public static bool operator == (Employee<T> employee1, Employee<T> employee2)
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

        public static bool operator != (Employee<T> employee1, Employee<T> employee2)
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
