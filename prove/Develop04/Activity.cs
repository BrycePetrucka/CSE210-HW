public class Activity
{
    // protected is like using private but allows classes that inherit from it to access them
    protected string _description;
    protected string _name;
    protected int _time;
    
    // using \b will change the cursor to previous spot ans using a new write will overwrite it.
    // Thread.Sleep(200) this is how to make things pause

    public static void LoadingAnimation()
        {
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
}