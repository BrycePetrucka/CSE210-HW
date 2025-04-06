using System.Runtime.Serialization;

public class Listing : Activity
{
    private List<string> _prompts = new List<string>();

    public Listing()
        {
        _name = "Listing Activity";
        _description = "This activity is focused on helping you to think about the good things in your life. It will ask a question and you need to answer it with as many examples from your life as you can.";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("What are your favorite conference talks?");
        }

    public void RunListing()
    {
        LoadingAnimation();
        int setTime = StartingMessage(_name, _description);
        int i = 0;
        Random random = new Random();
        int randomChoice = random.Next(1,7);
        foreach (string prompt in _prompts)
        {
            i += 1;
            if (i == randomChoice)
            {
                Console.WriteLine();
                Console.WriteLine($" --- {prompt} ---");
                Console.WriteLine();
            }
        }
        Console.Write($"Start listing in: ");
        CountdownAnimation(5);
        Console.WriteLine();
        _endTime = GetDuration(setTime);
        int counter = 0;
        while (DateTime.Now < _endTime)
        {
            Console.Write("- ");
            Console.ReadLine();
            counter += 1;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {counter} things! Well done.");
        Console.WriteLine();
        EndingMessage(setTime, _name);
        Console.Clear();
    }
}