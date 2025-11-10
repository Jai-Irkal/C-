namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Percy Jackson", "Rick Riordan", 200);

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            book1.PrintBook();
            Console.ReadLine();
        }
    }
}