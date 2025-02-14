using System.Reflection;

public class Book
{
    private string _title;
    private string _author;
    private string _checkOutDate;

    public Book(string title, string author)
    {
        _title = title;
        _author = author;
        _checkOutDate = "";
    }

    public void CheckOut()
    {
        _checkOutDate = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public bool IsCheckedOut()
    {
        bool isCheckedOut;
        if (_checkOutDate == "")
        {
            isCheckedOut = false;
        }
        else
        {
            isCheckedOut = true;
        }
        return isCheckedOut;
    }

    public void Display()
    {
        if (IsCheckedOut())
        {
        Console.WriteLine($"{_title} by {_author} checked out: {_checkOutDate}");
        }
        else
        {
            Console.WriteLine($"{_title} by {_author}");
        }
    }
}