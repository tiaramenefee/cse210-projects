using System;
using System.ComponentModel;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Movie favoriteMovie = new Movie();
        favoriteMovie._title = "Star Wars";
        favoriteMovie._year = 1977;
        favoriteMovie._runtime = 150;
        favoriteMovie._rating = "PG";

        Movie otherMovie = new Movie();
        otherMovie._title = "Avatar";
        otherMovie._year = 2000;
        otherMovie._rating = "PG-13";
        otherMovie._runtime = 162;

        Console.WriteLine(favoriteMovie._title);
    }

    static void DisplayMovie(Movie aMovie);
    {
        Console.WriteLine($"(aMovie._title) - (aMovie._year)");
    }
    


}   