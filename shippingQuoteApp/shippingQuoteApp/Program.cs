using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of your package.");
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the package width?");
                double packageWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                double packageHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                double packageLength = Convert.ToDouble(Console.ReadLine());

                double dimensionSum = packageWidth + packageHeight + packageLength;

                if (dimensionSum > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                else
                {
                    double quote = dimensionSum * packageWeight / 100;
                    Console.WriteLine("Your estimate total for shipping this package is: $" + Math.Round(quote,2));
                }

            }
            Console.Read();
        }
    }
}
