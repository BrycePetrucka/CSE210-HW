using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        /*
        this is how you do mulitple line comments
        */

        //Adj stands for adjective
        string adj = GetAdjective();
        string noun = GetNoun();
        int number = Multiply(17, 44);
        Console.WriteLine($"I looked out the window and saw {number} {adj} {noun}.");
    }

    static int Multiply(int number1, int number2)
    {
        int result = number1 * number2;
        return result;
    }

    static string GetAdjective()
    {
        List<string> words = new List<string>();
        words.Add("blue");
        words.Add("green");
        words.Add("small");
        string adj = words[2];
        return adj;
    }

    static string GetNoun()
    {
        string word = "bird";
        return word;
    }
}