using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthYearErrorHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");
            try
            {
                var age = Convert.ToUInt16(Console.ReadLine());
                var test = 1 / age;
                var today = DateTime.Today;
                var birthdate = today.Year - age;
                Console.WriteLine(birthdate);

                Console.Read();
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Please input a positive integer.");
                Console.Read();
            }
            catch(FormatException)
            {
                Console.WriteLine("Please input a positive integer.");
                Console.Read();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid integer.");
                Console.Read();
            }
        }
    }
}
