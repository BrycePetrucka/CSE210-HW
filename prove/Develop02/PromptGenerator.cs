using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Prompt
{
    public List<string> _promptList = new List<string>();


    public string RandomPrompt()
    {
        _promptList.Add("What did you eat today? ");
        _promptList.Add("What was one good thing that you did today? ");
        _promptList.Add("What did you learn today? ");
        _promptList.Add("What are you looking forward to tomorrow? ");
        _promptList.Add("If you could see sommeone right now who would it be? ");
        _promptList.Add("How are you going to make tomorrow better day? ");
        _promptList.Add("What superhero would you want to be? ");
        _promptList.Add("How can you help others feel Christs love? ");

        Random random = new Random();
        int i = random.Next(_promptList.Count);       
    return _promptList[i];
    }
}