using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        int magic_number;
        Random randomGenerator = new Random();
        magic_number = randomGenerator.Next(1,101);
        int guess = -1;

        while (magic_number != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magic_number)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Nice, you guessed it!");
            }
        }

        
        
    }
}