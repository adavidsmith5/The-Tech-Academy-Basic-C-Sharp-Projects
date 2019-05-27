using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string num = Console.ReadLine();

            File.WriteAllText(@"C:\Users\6420 i7\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\LoggingFiles\logs\log.txt", num);

            string returnNum = File.ReadAllText(@"C:\Users\6420 i7\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\LoggingFiles\logs\log.txt");
            Console.WriteLine(returnNum);
            Console.Read();
        }
    }
}
