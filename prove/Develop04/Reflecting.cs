public class Reflecting : Activity
{

    private List<string> _prompts = new List<string>();
    private List<string> _secondPrompts = new List<string>();
    private List<string> _usedPromopts = new List<string>();

    public Reflecting()
        {
            _name = "Reflecting Activity";
            // I couldnt think of original questions so I just used the examples from the assignment 
            _description = "The reflection activity is focused on helping you to remember when you have been strong and resiliant in your life. This will help you to see how strong you truly are.";
            _prompts.Add("Think of a time when you stood up for someone else.");
            _prompts.Add("Think of a time when you did something you thought was impossible.");
            _prompts.Add("Think of a time when you helped someone in need.");
            _prompts.Add("Think of a time when you did something selfless.");
            _secondPrompts.Add("Why was this experience meaningful to you?");
            _secondPrompts.Add("Have you ever done anything like this before?");
            _secondPrompts.Add("How did you get started?");
            _secondPrompts.Add("How did you feel when it was complete?");
            _secondPrompts.Add("What made this time different than other times when you were not as successful?");
            _secondPrompts.Add("What is your favorite thing about this experience?");
            _secondPrompts.Add("What could you learn from this experience that applies to other situations?");
            _secondPrompts.Add("What did you learn about yourself through this experience?");
            _secondPrompts.Add("How can you keep this experience in mind in the future?");
        }
    
    public void RunReflecting()
    {
        int i = 0;
        LoadingAnimation();
        int setTime = StartingMessage(_name, _description);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        
        Random random = new Random();
        int randomChoice = random.Next(1,5);
        foreach (string prompt in _prompts)
        {
            i += 1;
            if (i == randomChoice)
            {
                Console.WriteLine($" --- {prompt} --- ");
                Console.WriteLine();
            }
        }
        Console.WriteLine("Press enter to start once you have something in mind. ");
        Console.ReadLine();
        _endTime = GetDuration(setTime);
        bool stall = false;
        while (DateTime.Now < _endTime)
        {
            i = 0;
            random = new Random();
            randomChoice = random.Next(1,10);
            if (_usedPromopts.Count() != _secondPrompts.Count())
            {
                foreach (string prompt in _secondPrompts)
                {
                    i += 1;
                    if (i == randomChoice)
                    {
                        if (_usedPromopts.Contains(prompt))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.Write($"{prompt} ");
                            _usedPromopts.Add(prompt);
                            LoadingAnimation2();
                            Console.WriteLine();
                        }
                    }
                }
                if (_usedPromopts.Count() == _secondPrompts.Count())
                {
                    Console.WriteLine();
                    Console.WriteLine("There are no more prompts for this section. Please continue to reflect on the previous prompts for the remainder of the time.");
                    stall = true;
                }
            }
            if (stall)
            {
                Console.Write("");
            }

        }
        foreach (string prompt in _usedPromopts)
        {
            _usedPromopts.Append(prompt);
        }
        Console.WriteLine();
        EndingMessage(setTime, _name);
        Console.Clear();
    }
}