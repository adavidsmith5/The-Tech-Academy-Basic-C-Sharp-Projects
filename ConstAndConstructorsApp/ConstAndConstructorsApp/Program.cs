using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAndConstructorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = 15.6;
            CalculateWeight findWeight = new CalculateWeight(mass);
            Console.WriteLine("The weight of an object with mass {0} kg on Earth is {1} Newtons.", mass, findWeight.weight);

            const double accelerationDueToGravityJupiter = 24.5;
            CalculateWeight findWeightJupiter = new CalculateWeight(accelerationDueToGravityJupiter, mass);
            Console.WriteLine("However, if this mass were on Jupiter, it would weight {0} Newtons!", findWeightJupiter.weight);

            Console.Read();
        }
    }
}
