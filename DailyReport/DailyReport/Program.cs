using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            //shows daily report title with \n line break
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");
            //stops the program from closing automatically
            Console.ReadLine();
            //asks name
            Console.WriteLine("What is your name?");
            //stops program from closing
            Console.ReadLine();
            //asks what course student is on
            Console.WriteLine("What course are you on?");
            Console.ReadLine();
            Console.WriteLine("What page number?");
            //creates string for page number
            string pageNumber = Console.ReadLine();
            //converts page number to integer
            int pageNum = Convert.ToInt32(pageNumber);
            Console.ReadLine();
            Console.WriteLine("Is there anything you need help with? Please answer \"true\" or \"false\".");
            Console.ReadLine();
            bool help = true;
            string needHelp = Convert.ToString(help);
            Console.ReadLine();
            Console.WriteLine("Were there any positive experience you'd like to share? Please give specifics.");
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            Console.ReadLine();
            Console.WriteLine("How many Hours did you study?");
            string studyHours = Console.ReadLine();
            int hours = Convert.ToInt32(studyHours);
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers." +
                "\nAn Instructor will respond to this shortly.\n" +
                "Have a great day!");
            Console.ReadLine();


        }
    }
}
