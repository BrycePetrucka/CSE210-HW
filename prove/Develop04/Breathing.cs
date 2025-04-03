using System.Xml.Serialization;

public class Breathing : Activity
{
    // private const INHALE_TIME;
    // private const EXHALE_TImE;

    public Breathing()
    {
        _name = "Breathing activity";
        _description = "";
    }

    public void RunBreathing()
    {
        LoadingAnimation();
        
        bool run = true;
        while (run == true)
        {
            // insert timer
            if (_time != 0)
            {
                Console.WriteLine("Breathe in");
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine("Breathe out");
                Thread.Sleep(6000);
                Console.WriteLine();
            }
        }
    }
}