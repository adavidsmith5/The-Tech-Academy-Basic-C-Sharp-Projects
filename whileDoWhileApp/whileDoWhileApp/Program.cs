using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileDoWhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "password1234";
            bool correctPassword = false;
            bool correctNumber = false;
            int favoriteNumber = 5;
            while (!correctPassword)
            {
                Console.Write("Please enter your password: ");
                string passwordEntered = Console.ReadLine();
                if (passwordEntered == password)
                {
                    Console.WriteLine("You have entered the correct password");
                    correctPassword = true;
                }
                else
                {
                    Console.WriteLine("You have entered the wrong password. Try again.");
                }
            }
            


            Console.WriteLine("Verify your account by entering your favorite number: ");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (enteredNumber)
                {
                    case 35:
                        Console.WriteLine("That was your old favorite number.");
                        Console.WriteLine("Try again: ");
                        enteredNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("What are you, 5?");
                        Console.WriteLine("Try again: ");
                        enteredNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 100:
                        Console.WriteLine("That was just a ridiculous guess.");
                        Console.WriteLine("Try again: ");
                        enteredNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("That is the correct number. Your account has been verified");
                        correctNumber = true;
                        break;
                    default:
                        Console.WriteLine("Try again: ");
                        enteredNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!correctNumber);

            Console.Read();
        }
    }
}
