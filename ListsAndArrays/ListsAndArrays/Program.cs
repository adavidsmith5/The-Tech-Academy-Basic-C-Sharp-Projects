using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[3] { "hello", "is it me you're looking for?", "i can see it in your eyes" };
            int stringArrayIndexChosen = -1;
            
            while(stringArrayIndexChosen < 0 || stringArrayIndexChosen > 2)
            {
                Console.WriteLine("Please select an index between 0 and 2 to see what message I have for you.");
                stringArrayIndexChosen = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(stringArray[stringArrayIndexChosen]);

            int[] intArray = new int[5] { 4, 85, 29, 10, -34499 };
            int intArrayIndexChosen = -1;

            while(intArrayIndexChosen < 0 || intArrayIndexChosen > 4)
            {
                Console.WriteLine("Please select an index between 0 and 4 to see the hidden number.");
                intArrayIndexChosen = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(intArray[intArrayIndexChosen]);

            List<string> stringList = new List<string>();
            stringList.Add("Here's a new string");
            stringList.Add("And another");
            stringList.Add("I can't believe you chose this one.");
            stringList.Add("Great choice. Index 3 is probably the best.");

            int listIndexChosen = -1;
            while(listIndexChosen < 0 || listIndexChosen > 3)
            {
                Console.WriteLine("Please select an index between 0 and 3 to see the hidden string.");
                listIndexChosen = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(stringList[listIndexChosen]);

            Console.Read();
        }
    }
}
