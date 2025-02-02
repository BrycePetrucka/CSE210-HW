using System;
using System.Net.Quic;
using System.IO;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("Please type the number of the action you want to do. ");
        Console.WriteLine("1. Write Entry");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Save Journal");
        Console.WriteLine("4. Load Journal");
        Console.WriteLine("5. Quit");
        Console.Write("What do you want to do? ");
    }

    static void Main(string[] args)
    {
        Journal newjournal = new Journal();
        bool run = true;
        while (run)
        {
            DisplayMenu();
            string userAction = Console.ReadLine();
            Console.WriteLine();
        
            // Write Entry
            if (userAction == "1")
            {
                Entry entry = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                entry._dateTime = theCurrentTime.ToShortDateString();

                // promptGood is what I am using to have the user say they like the prompt
                // or want a new one
                string promptGood = "1";
                Prompt userPrompt = new Prompt(); 
                
            while(promptGood != "2")
            {
                entry._prompt = userPrompt.RandomPrompt();
                Console.WriteLine($"{entry._prompt}");
                Console.WriteLine("Would you like a different prompt? \n1. Yes \n2. No");
                promptGood = Console.ReadLine();   
                Console.WriteLine("");
            }
                Console.WriteLine($"{entry._prompt}");
                string userEntry = Console.ReadLine();
                entry._userEntry = userEntry;

                newjournal._journalList.Add(entry);
                
            }
            // Display Enteries
            else if (userAction == "2")
            {
                newjournal.DisplayJournal();
            }
            // Save Entries
            else if (userAction == "3")
            {               
                newjournal.SaveEnteries();
            }
            // Load entries
            else if (userAction == "4")
            {
                newjournal.LoadEnteries();
            }
            else if (userAction == "5")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
                Console.WriteLine();
            }
        }   
    }
}