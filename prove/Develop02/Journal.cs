using System.IO;
using System.IO.Enumeration;


public class Journal
{
    public List<Entry> _journalList = new List<Entry>();


    public void DisplayJournal()
    {
        foreach (Entry entry in _journalList)
        {
            entry.Display();
        }
        
    }
    public void SaveEnteries()
    {
        Console.Write("What do you want your file to be called?");
        string txtname = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(txtname))
            {
                foreach (Entry entry in _journalList)
                {
                    outputFile.WriteLine($"{entry._dateTime}~{entry._prompt}~{entry._userEntry}");
                }
            }
    }
    public void LoadEnteries()
    {
        Console.Write("What file would you like to load? ");
        string loadFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            string dateTime = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            Console.WriteLine($"{dateTime}, {prompt} \n {entry}");
        }
    }
    
}
