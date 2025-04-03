using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMenu()
        {
            Console.WriteLine("Welcome to the activity selector!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Which activity would you like to do? ");
        }

        bool run = true;

        while (run == true)
        {
            DisplayMenu();
            string userChoice = Console.ReadLine();
            Console.WriteLine("How long would you like to do the activity in second? ");
            string setTime = Console.ReadLine();
            int time = int.Parse(setTime);

            Breathing breathe = new Breathing();
            Listing list = new Listing();
            Reflecting reflect = new Reflecting();

            // DateTime startingtime = DateTime.Now;
            // DateTime endTime = startingtime.AddSeconds(time);
            // while (DateTime.Now < endingTime)


            if (userChoice == "1")
            {
                breathe.RunBreathing();
            }
            else if (userChoice == "2")
            {
                list.RunListing();
            }
            else if (userChoice == "3")
            {
                reflect.RunReflecting();
            }
            else if (userChoice == "4")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid option. (1, 2, 3, or 4)");
            }
        }
        
    }
}