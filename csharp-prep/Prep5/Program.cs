using System;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string username = AskUserName();
        int userFavNumber = AskUserNumber();
        int squaredNumber = SquareNumber(userFavNumber);
        DisplayInfo(username, squaredNumber);

    }
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string AskUserName()
    {
        Console.Write("What is your name? ");
        string usernmae = Console.ReadLine();
        return usernmae;
    }
    static int AskUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int fav_number = int.Parse(Console.ReadLine());
        return fav_number;
    }
    static int SquareNumber(int fav_number)
    {
        int squarednumber = fav_number * fav_number;
        return squarednumber;
    }  
    static void DisplayInfo(string username, int squarednumber)
    {
        Console.WriteLine($"{username}, your favorite number squared is {squarednumber}.");
    }
}