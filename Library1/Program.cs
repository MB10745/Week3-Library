class Book
{
    string Title; //First attribute
    string Author; //Second attribute
    string ISBN; //Third attribute

    //Example of a constructor that allows us to 'construct' a new Book object
    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
    }

    //Declaring a method
    void Displayinfo()
    {
        Console.WriteLine($"Book Title: {Title}\nBook Author: {Author}\nBook ISBN: {ISBN}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Create new instance (object) of the Book class (with new constructor)
        //Note how object name differs from class name
        Book book = new Book("C# for beginners", "BillGates", "12345678");

        /*//Create new instance (object) of the Book class
        //Note how object name differs from class name
        Book book = new Book();

        //This info is for one book in our library
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";

        //Output the book info to the console
        Console.WriteLine($"Book Title: {book.Title}");
        Console.WriteLine($"Book Author: {book.Author}");
        Console.WriteLine($"Book ISBN: {book.ISBN}");

        //This is another book object
        //Object name (instance) is 'book1' and NOT 'book'
        Book book1 = new Book();
        book1.Title = "C# Methods and classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667778";*/

        //Output book info to the console (using method)
        //book1.Displayinfo();
        book.Displayinfo();
    }
}