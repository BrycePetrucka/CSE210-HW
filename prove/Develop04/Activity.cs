using System.Diagnostics;

public class Activity
{
    // protected is like using private but allows classes that inherit from it to access them
    protected string _description;
    protected string _name;
    protected int _duration;
    protected DateTime _startTime;
    protected DateTime _endTime;
    
    // using \b will change the cursor to previous spot ans using a new write will overwrite it.
    // Thread.Sleep(200) this is how to make things pause

    public static void LoadingAnimation()
    {
        Console.Clear();
        Console.WriteLine();
        Console.Write("Loading ");
    
        for (int i = 0 ; i < 7 ; i++)
        {
            Console.Write("x");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("+");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    public static void LoadingAnimation2()
    {
        for (int i = 0 ; i < 1 ; i++)
        {
            Console.Write("x");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("+");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    public static void CountdownAnimation(int length)
    {
        int duration = length;
        for (int i = 0 ; i < duration ; i++)
            {
                Console.Write($"{length}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                length = length -1;
            }
    }

    public int StartingMessage(string name, string description)
    {
        Console.WriteLine($"Welcome to the {name}.");
        Console.WriteLine($"{description}");
        Console.WriteLine("How long would you like to do the activity in seconds? ");
        string setTime = Console.ReadLine();
        int time = int.Parse(setTime);
        LoadingAnimation();
        return time;
    }
    public void EndingMessage(int time, string name)
    {
        Console.WriteLine();
        Console.Write($"You completed {time} seconds of the {name}! Well done. ");
        LoadingAnimation2();
    }


    public DateTime GetDuration(int setTime)
    {
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(setTime);
        return _endTime;
    }
}