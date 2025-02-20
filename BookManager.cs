class BookManager
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        Console.WriteLine("Adding book to list...");
        books.Add(book);
        Console.WriteLine("Book added successfully!");
    }

    public void ShowBooks()
    {
        Console.WriteLine("Displaying book list...");
        if (books.Count == 0)
        {
            Console.WriteLine("Book list is empty.");
            return;
        }

        Console.WriteLine("\nBook list:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void RemoveBook(string title)
    {
        var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine("Book removed successfully!");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public void SearchByAuthor(string author)
    {
        var results = books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        if (results.Count == 0)
        {
            Console.WriteLine("No books found by this author.");
            return;
        }

        Console.WriteLine("\nBooks by " + author + ":");
        foreach (var book in results)
        {
            Console.WriteLine(book);
        }
    }

    public void UpdateBook(string title, string newTitle, string newAuthor, int newYear)
    {
        var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            book.Title = newTitle;
            book.Author = newAuthor;
            book.Year = newYear;
            Console.WriteLine("Book updated successfully!");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
}