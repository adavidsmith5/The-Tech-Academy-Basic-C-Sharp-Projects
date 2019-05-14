using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DivideByNumber compute = new DivideByNumber();
            string isThereRemainder;
            int quotient;
            int remainder;

            Console.WriteLine("Please enter a number to be divided.");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number to divide with.");
            string divisor = Console.ReadLine();
            
            compute.DivideEvenly(input, out isThereRemainder, out quotient, out remainder, divisor);

            if (divisor == "")
            {
                divisor = "2";
            }

            Console.WriteLine(isThereRemainder);
            Console.WriteLine(divisor + " goes into " + input + " " + quotient + " times with a remainder of " + remainder);
            Console.WriteLine(PrimeNumbers.PrimeNumberDefinition);
            if(remainder == 0 || input % 2 == 0)
            {
                Console.WriteLine(PrimeNumbers.NotPrime);
            }
            else
            {
                Console.WriteLine(PrimeNumbers.MaybePrime);
            }

            Console.Read();
        }
    }
}
