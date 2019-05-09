using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for the program to do calculations on.");
            int num = Convert.ToInt32(Console.ReadLine());

            int addResult = Calculations.Add(num);
            Console.WriteLine(addResult);

            int subtractResult = Calculations.Subtract(num);
            Console.WriteLine(subtractResult);

            int multiplyResult = Calculations.Multiply(num);
            Console.WriteLine(multiplyResult);

            Console.Read();
        }
    }
}
