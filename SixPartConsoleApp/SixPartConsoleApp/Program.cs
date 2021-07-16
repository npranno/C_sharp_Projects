using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 1");
            // One dimensional array
            // Create loop that adds each user text to the string 

            string[] listwords = new string[4];

            for (int i = 0; i < 4; i++) //as each string is input, it will increment by 1, adding to listwords 
            {
                Console.WriteLine("Please enter some text.");

                listwords[i] = Console.ReadLine();
            }
            Console.WriteLine("here are the texts you entered: ");

            foreach (string i in listwords)
            {

                Console.WriteLine(i);
            }

            //Console.WriteLine("Exercise 2"); //infinite loop
            ////comment out to fix infinite loop
            //Console.ReadLine();

            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine("Infinite Loop" + i); //this continues to loop and increment by 1 forever
            //}

            Console.WriteLine("Exercise 3"); //fix infinite loop
            for (int i = 0; i < 5; i++) //this makes it so it will iterate as long as "i" is less than 5
            {
                Console.WriteLine("Fix Infinite Loop: " + i);
            }

            Console.WriteLine("Exercise 4");
            //iterate until a "<" operator is found
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("A '<' operator has been found: " + j);
                j++;
            }

            Console.WriteLine("Exercise 5");
            //iterate until a "<=" is found
            int k = 0;
            while (k <= 5)
            {
                Console.WriteLine("A '<=' operator has been found: " + k);
                k++;
            }

            Console.WriteLine("Exercises 6, 7, and 8");
            // create a list for user to select and search for string that displays matching the correct index
            List<string> colors = new List<string>() { "red", "blue", "yellow", "green", "orange", "purple" };
            Console.WriteLine("Please enter a color to search:");
            string input = Console.ReadLine();
            bool records = false;

            foreach (string i in colors)
            {
                if (input == i)
                {
                    Console.WriteLine("You chose the color at index number " + colors.IndexOf(i));
                    records = true;
                    break;
                }
            }
            if (!records)
            {
                Console.WriteLine("Your input doesn't match any color in the database.");
            }

            Console.WriteLine("Exercises 9 and 10");
            //create list with two identical strings
            //ask user to select a string to search for within the list
            //create loop to iterate through list and displays indices of array where matching text is located

            List < string > colors1 = new List<string>() { "red", "red", "blue", "blue", "yellow", "yellow", "green", "green",
            "orange", "orange", "purple", "purple"};
            Console.WriteLine("Please enter a color to search:");
            string input1 = Console.ReadLine();
            bool records1 = false;

            for (int x = 0; x < 12; x++)
            {
                if (colors1[x] == input1)
                {
                    Console.WriteLine("The color you picked has an index of: " + x);
                    records1 = true;
                }
            }
            if (!records1) //if color doesnt exist it it will print the following to the screen
            {
                Console.WriteLine("The index you chose does not exist in the database of colors.");
            }

            Console.WriteLine("Exercises 11 and 12");
            //check if item is already in list then displays whether or not it is already in the list
            List<string> exists = new List<string>(); //create new list that contains multiple inputs

            foreach (string y in colors1)
            {
                if (exists.Contains(y))
                {
                    Console.WriteLine("This color exists in the database: ");
                    Console.WriteLine(y);
                }
                else
                {
                    exists.Add(y);
                }
            }
            Console.ReadLine();
        }
    }
}
