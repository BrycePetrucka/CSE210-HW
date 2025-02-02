using System;
using System.Runtime.CompilerServices;

class Program
{
    static void displayMenu()
        {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Add Job");
        Console.WriteLine("2. Display Resume");
        Console.WriteLine("3. Quit");
        Console.WriteLine("");
        }

    static void Main(string[] args)
    {
        displayMenu();

        bool keepRunning = true;
        while(keepRunning) // You can use (keepRunning == true) but you can use the other method too
        {
            Resume theResume = new Resume();
            Console.Write("Enter choice number: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                //add new job
                Console.Write("What is the name of the company? ");
                string company = Console.ReadLine();

                Console.Write("What is the position? ");
                string position = Console.ReadLine();

                Job newJob = new Job();
                newJob._company = company;
                newJob._jobTitle = position;
                newJob._startYear = 2015;
                newJob._endYear = 2020;

                theResume._jobs.Add(newJob);
            }
            else if (choice == "2")
            {
                //display resume
                theResume.DisplayResume();
            }
            else if (choice == "3")
            {
                //quit
                keepRunning = false;
            }
            else
            {
                // tell them to try again
                Console.WriteLine("Sorry that was not one of the options, try a different number");
            }
        
        Job job1 = new Job();
        job1._company = "Hollywood Feed";
        job1._endYear = 2024;
        job1._startYear = 2022;
        job1._jobTitle = "Sales associate";

        Job job2 = new Job();
        job2._company = "AVALan Wireless";
        job2._endYear = 2020;
        job2._startYear = 2019;
        job2._jobTitle = "Floor Worker";

        Resume yourResume = new Resume();
        yourResume._name = "Bryce Petrucka";
        yourResume._jobs.Add(job1);
        yourResume._jobs.Add(job2);

        yourResume.DisplayResume();
        

        }
    }
}