using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type in a number to add it to the list, when you are done,type 0.");
        int added_number = -1;
        List<int> numbers = new List<int>();
        float sum = 0;
        int biggest_number = 0;
        int counter = 0;

        while (added_number != 0)
        {
            Console.Write("Add a number: ");
            added_number = int.Parse(Console.ReadLine());
            numbers.Add(added_number);
        }

        foreach (int number in numbers)
        {
            sum = sum + number;
            counter += 1;
            if (biggest_number < number)
            {
                biggest_number = number;
            }
        }
        float average = sum / (counter - 1);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average was: {average}");
        Console.WriteLine($"The biggest number was: {biggest_number}");


    }
}