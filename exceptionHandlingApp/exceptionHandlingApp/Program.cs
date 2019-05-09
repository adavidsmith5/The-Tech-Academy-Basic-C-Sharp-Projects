using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            numberList.Add(11);
            numberList.Add(449);
            numberList.Add(26);
            numberList.Add(4);
            numberList.Add(9);
            numberList.Add(72);
            numberList.Add(23);

            try
            {


                Console.WriteLine("Please enter a number to use for division");
                int divisor = Convert.ToInt32(Console.ReadLine());

                foreach (int num in numberList)
                {
                    float quotient = (float)num / (float)divisor;
                    Console.WriteLine(num + " divided by " + divisor + " equals " + quotient);
                }

            }

            catch (FormatException e)
            {
                Console.WriteLine("Please enter an integer.");
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("You have divided by zero. Please choose another number.");
            }

            finally
            {
                Console.WriteLine("The app has completed, please run again if you did  not get your desired answer.");
            }

            Console.ReadLine();

        }
    }
}
