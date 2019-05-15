using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedMethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operation = new Operations();

            int multiplyByNegTwo = Operations.Calculation(4);
            Console.WriteLine(multiplyByNegTwo);

            int roundUp = Operations.Calculation(2.98);
            Console.WriteLine(roundUp);

            int addThree = Operations.Calculation("4");
            if (addThree != 0)
            {
                Console.WriteLine(addThree);
            }
            

            Console.Read();
        }
    }
}
