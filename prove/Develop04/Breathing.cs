using System.Xml.Serialization;

public class Breathing : Activity
{
    // private const INHALE_TIME;
    // private const EXHALE_TImE;

    public Breathing()
    {
        _name = "Breathing Activity";
        _description = "This activity is aimed at helping you to control your breathing in order to help calm down negative emotions like stress and anxiety. Please follow the instructions as they appear on the screen.";
    }

    public void RunBreathing()
    {
        LoadingAnimation();
        int setTime = StartingMessage(_name, _description);
        _endTime = GetDuration(setTime);
        int counter = 0;

        while (DateTime.Now < _endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in: ");
            CountdownAnimation(5);
            Console.WriteLine();
            Console.Write("Breathe out: ");
            CountdownAnimation(6);
            Console.WriteLine();
            counter += 1;
        }
        Console.WriteLine();
        EndingMessage(setTime, _name);
        Console.Clear();
    }
}