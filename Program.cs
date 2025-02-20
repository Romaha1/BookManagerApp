class Program
{
    static void Main()
    {
        Console.WriteLine("Initializing Book Manager...");
        BookManager manager = new BookManager();
        
        while (true)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Show books");
            Console.WriteLine("3. Remove a book");
            Console.WriteLine("4. Search by author");
            Console.WriteLine("5. Update a book");
            Console.WriteLine("6. Exit");
            Console.Write("Your choice: ");
            
            string choice = Console.ReadLine();
            Console.WriteLine($"User selected option: {choice}");
            
            switch (choice)
            {
                case "1":
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter publication year: ");
                    
                    if (!int.TryParse(Console.ReadLine(), out int year))
                    {
                        Console.WriteLine("Invalid input for year. Please enter a valid number.");
                        break;
                    }
                    
                    manager.AddBook(new Book(title, author, year));
                    break;
                
                case "2":
                    manager.ShowBooks();
                    break;
                
                case "3":
                    Console.Write("Enter book title to remove: ");
                    string removeTitle = Console.ReadLine();
                    manager.RemoveBook(removeTitle);
                    break;
                
                case "4":
                    Console.Write("Enter author name to search: ");
                    string searchAuthor = Console.ReadLine();
                    manager.SearchByAuthor(searchAuthor);
                    break;
                
                case "5":
                    Console.Write("Enter book title to update: ");
                    string updateTitle = Console.ReadLine();
                    Console.Write("Enter new title: ");
                    string newTitle = Console.ReadLine();
                    Console.Write("Enter new author: ");
                    string newAuthor = Console.ReadLine();
                    Console.Write("Enter new publication year: ");
                    
                    if (!int.TryParse(Console.ReadLine(), out int newYear))
                    {
                        Console.WriteLine("Invalid input for year. Please enter a valid number.");
                        break;
                    }
                    
                    manager.UpdateBook(updateTitle, newTitle, newAuthor, newYear);
                    break;
                
                case "6":
                    Console.WriteLine("Exiting program...");
                    return;
                
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}