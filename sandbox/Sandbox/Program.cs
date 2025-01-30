using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        Movie favoriteMovie = new Movie();
        favoriteMovie._title = "Star Wars";
        favoriteMovie._rating = "PG-13";
        favoriteMovie._year = 1977;
        favoriteMovie._runtime = 150;

        Movie otherMovie = new Movie();
        otherMovie._runtime = 162;
        otherMovie._title = "Avatar";
        otherMovie._rating = "PG-13";
        otherMovie._year = 2009;

        Console.WriteLine(favoriteMovie._rating);
        displayMovie(favoriteMovie);
        displayMovie(otherMovie);

        favoriteMovie.Display();
    }

    static void displayMovie(Movie aMovie)
    {
        Console.WriteLine($"{aMovie._title} - {aMovie._year}");
    }
}