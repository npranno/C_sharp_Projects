using System;
using System.Collections.Generic;




class Program
{
    static void Main()
    {
        // this creates a list to ask the user index input and then display the value
        string[] wordArray = { "This", "Is", "A", "Random", "Sentence" };
        Console.WriteLine("Enter a number between 0 and 4 to receive a random word:");
        int input = Convert.ToInt32(Console.ReadLine());


        while (input < 0 || input >= 5) //while user input value is equal to or greater than 5 it will continue to loop
        {
            Console.WriteLine("The value you entered was not found. Please try again.");
            input = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("You picked " + wordArray[input] + "!\n");

        // this creates an int array to ask the user for index input and then display the value

        int[] numArray = { 0, 1, 2, 3, 4, 5 };
        Console.WriteLine("Enter a number between 0 and 5 to display that number:");
        int input2 = Convert.ToInt32(Console.ReadLine());


        while (input2 < 0 || input2 >= 6)
        {
            Console.WriteLine("The value you entered was not found. Please try again.");
            input2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Your value is " + numArray[input2] + "!\n");


        // this creates a list to ask the user for index input and display and then display the value
        List<string> stringArray = new List<string>();
        stringArray.Add("Hello World!");
        stringArray.Add("Keep Truckin'.");
        stringArray.Add("Random Sentence...");

        Console.WriteLine("Enter a number between 0 and 2 to display a random sentence:");
        int input3 = Convert.ToInt32(Console.ReadLine());


        while (input3 < 0 || input3 >= 3)
        {
            Console.WriteLine("The value you entered was not found. Please try again.");
            input3 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Your sentence is: " + stringArray[input3]);
        Console.ReadLine();

        Console.WriteLine("Have a fantastic day!");
        Console.ReadLine();
    }
}


