class Book
{
    string Title; //First attribute
    string Author; //Second attribute
    string ISBN; //Third attribute

    static void Main(string[] args)
    {
        //Create new instance (object) of the Book class
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
    }
}