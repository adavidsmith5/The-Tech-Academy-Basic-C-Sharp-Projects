using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userMathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to multiply by 50: ");
            uint multNum = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("The result is: " + multNum * 50);

            Console.WriteLine("Please enter a number to add 25 to: ");
            uint addNum = Convert.ToUInt32(Console.ReadLine());
            uint result = addNum + 25;
            Console.WriteLine("The result is: " + result);

            Console.WriteLine("Please enter a number to divide by 12.5: ");
            double divNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The result is: " + divNum / 12.5);

            Console.WriteLine("Please enter a number: ");
            double checkNum = Convert.ToDouble(Console.ReadLine());
            bool greaterThanFifty = checkNum > 50;
            Console.WriteLine("Your number is greater than fifty: " + greaterThanFifty);

            Console.WriteLine("Please enter a number: ");
            double divBySeven = Convert.ToDouble(Console.ReadLine());
            byte remainder = Convert.ToByte(divBySeven % 7);
            Console.WriteLine("The remainder when dividing your number by 7 is: " + remainder);

            Console.Read();
        }
    }
}
