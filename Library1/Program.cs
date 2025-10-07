/*class Book
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

        //This is another book object
        //Object name (instance) is 'book1' and NOT 'book'
        Book book1 = new Book();
        book1.Title = "C# Methods and classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667778";

        //Output book info to the console (using method)
        //book1.Displayinfo();
        book.Displayinfo();
    }
}*/

using Library1;
class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("Ultimate C#","Microsoft","2233445");
        Console.WriteLine("Currently available books");
        book.DisplayInfo();
        book1.DisplayInfo();

        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0790345666);
        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();

        Person person = new Person(); // Create instance
        person.FirstName = "John"; // Access public property
        person.LastName = "Doe";
        Console.WriteLine(person.GetFullName()); // Outputs "John Doe"
    }
}