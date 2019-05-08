using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Take a user's name as input and add it to a set list of strings to make simple sentences
            //string[] strings = new string[] { "My name is ", "The coolest person in the world is ", "You wish you could be " };

            //Console.WriteLine("What is your name? ");
            //string name = Console.ReadLine();

            //for (int i = 0; i < strings.Length; i++)
            //{
            //    strings[i] = strings[i] + name;
            //}

            //for (int j = 0; j < strings.Length; j++)
            //{
            //    Console.WriteLine(strings[j]);
            //}

            //infinite loop
            //for (int j = 0; j < 5; j--)
            //{
            //    Console.WriteLine("This isn't going to end well!");
            //}

            //fixed infinite loop
            //for (int j = 0; j < 5; j++)
            //{
            //    Console.WriteLine("This isn't going to end well!");
            //}

            //for (int k = 0; k < 10; k+=2)
            //{
            //    Console.WriteLine("I like even numbers!");
            //}

            //for (int i = 0; i <= 2; i+=3)
            //{
            //    Console.WriteLine("That was quick.");
            //}

            //list of unique words for user to search
            //List<string> randomWords = new List<string>();
            //randomWords.Add("twelve");
            //randomWords.Add("assist");
            //randomWords.Add("workflow");
            //randomWords.Add("adds");
            //randomWords.Add("quick");
            //randomWords.Add("launch");
            //randomWords.Add("debug");
            //randomWords.Add("program");

            //Console.WriteLine("Please enter a word that you would like to check for in the list.");
            //string input = Console.ReadLine();

            //for (int i = 0; i < randomWords.Count; i++)
            //{
            //    if (randomWords[i] == input)
            //    {
            //        Console.WriteLine("The index of the word you searched for is " + i);
            //        break;
            //    }
            //    else if (i == randomWords.Count - 1)
            //    {
            //        Console.WriteLine("The word you are searching for is not in the list.");
            //    }
            //}


            //Create a list of strings, ask a user to search for a word in the list. If the word appears, display the index of the word, or if it appears more than once
            //display every index. If it does not appear in the list, inform the user.

            //List<string> randomWords = new List<string>();
            //randomWords.Add("twelve");
            //randomWords.Add("assist");
            //randomWords.Add("program");
            //randomWords.Add("workflow");
            //randomWords.Add("adds");
            //randomWords.Add("program");
            //randomWords.Add("quick");
            //randomWords.Add("launch");
            //randomWords.Add("assist");
            //randomWords.Add("debug");
            //randomWords.Add("twelve");
            //randomWords.Add("program");
            //int count = 0;

            //Console.WriteLine("Please enter a word that you would like to check for in the list.");
            //string input = Console.ReadLine();

            //for (int i = 0; i < randomWords.Count; i++)
            //{
            //    if (randomWords[i] == input)
            //    {
            //        Console.WriteLine("Your word appears at index " + i);
            //        count++;
            //    }
            //    else if (i == randomWords.Count - 1 && count == 0)
            //    {
            //        Console.WriteLine("The word you are searching for is not in the list.");
            //    }
            //}

            //Create a list of strings, and display each string, checking if it has appeared in the list already or not.

            List<string> randomWords = new List<string>();
            randomWords.Add("twelve");
            randomWords.Add("assist");
            randomWords.Add("program");
            randomWords.Add("workflow");
            randomWords.Add("adds");
            randomWords.Add("program");
            randomWords.Add("quick");
            randomWords.Add("launch");
            randomWords.Add("assist");
            randomWords.Add("debug");
            randomWords.Add("twelve");
            randomWords.Add("program");
            int count = 0;

            foreach (string word in randomWords)
            {
                int wordCount = 1;
                for (int i = 0; i < count; i++)
                {
                    if (word == randomWords[i])
                    {
                        wordCount++;
                    }
                }
                count++;
                Console.WriteLine(word + " has appeared " + wordCount + " time(s).");

            }


            Console.Read();

        }
    }
}
