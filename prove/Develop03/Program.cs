using System;
using System.Diagnostics.Metrics;
using System.Reflection;

class Program
{
    
    static void Main(string[] args)
    {
        Reference theScripture = new Reference("Moroni", 10, 5, 6);
        Scripture moroni10 = new Scripture(theScripture, "And by the power of the Holy Ghost ye may know the truth of all things. And whatsoever thing is good is just and true; wherefore, nothing that is good denieth the Christ, but acknowledgeth that he is.");

        moroni10.ReferenceBypass(theScripture);
        bool run = true;
        bool allHidden = false;

        while (run == true)
        {
            moroni10.DisplayScripture();
            Console.WriteLine("");
            Console.WriteLine("Please push enter to continue, or type 'quit' to quit. ");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "quit")
            {
                run = false;
            }
            else if (allHidden == true)
            {
                run = false;
            }
            else if (userInput == "")
            {
                run = moroni10.AllHiddenChecker();
            }
            Console.Clear();
            
        }
    }
}