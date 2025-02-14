public class Library
{
    private List<Book> _books;

    public Library()
    {
        _books = new List<Book>();
    }

    public void AddBook(Book thebook)
    {
        _books.Add(thebook);
    }

    public void DisplayCatalog()
    {
        Console.WriteLine("The catalog is:");

        foreach (Book b in _books)
        {
            b.Display();
        }
    }
}