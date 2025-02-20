using System;
using System.Collections.Generic;
using System.Linq;

// Book class
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Console.WriteLine($"Creating book: {title}, {author}, {year}");
        Title = title;
        Author = author;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Title} by {Author}, {Year}";
    }
}
