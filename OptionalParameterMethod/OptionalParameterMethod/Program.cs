using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the mass as an integer");
            int mass = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the gravitational constant as an integer, or leave blank if on Earth");
            string gravityResponse = Console.ReadLine();

            int forceOfGravity;
            if(gravityResponse != "")
            {
                int GC = Convert.ToInt32(gravityResponse);
                forceOfGravity = OptionalParameter.ForceOfGravity(mass, GC);
            }
            else
            {
                forceOfGravity = OptionalParameter.ForceOfGravity(mass);
            }
            Console.WriteLine(forceOfGravity);

            Console.Read();

        }
    }
}
