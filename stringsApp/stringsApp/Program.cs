using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Tony";
            string middleName = "David";
            string lastName = "Smith";

            string fullName = firstName + " " + middleName + " " + lastName;

            Console.WriteLine(fullName);

            string exclamation = "this is amazing!";
            exclamation = exclamation.ToUpper();

            Console.WriteLine(exclamation);


            StringBuilder sb = new StringBuilder();

            sb.Append("\tThis is the first sentence of an \"amazing\" paragraph.");
            sb.Append("\nIt will blow you away how much \"awesome\" stuff is in this paragraph.");
            sb.Append("\nYou're welcome for me allowing you to read this paragraph.");
            sb.Append("\nYou should probably be paying me money just for being able to read these words.");
            sb.Append("\nIf you've made it this far, I am sorry that this is not an amazing paragraph.");
            sb.Append("\nI lied.");

            Console.WriteLine(sb);

            Console.Read();
        }
    }
}
