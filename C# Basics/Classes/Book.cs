namespace Classes
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        public static int bookCount = 0;
        // Constructor
        public Book(string title, string author, int pages)
        {
            Console.WriteLine("Creating Book");
            this.title = title;
            this.author = author;
            this.pages = pages;
            bookCount++;
        }

        public void PrintBook()
        {
            Console.WriteLine("Book Title: " + this.title);
            Console.WriteLine("Author: " + this.author);
            Console.WriteLine("Pages: " + this.pages);
        }
        
        // Getters
        public string Title
        {
            get { return title; }
            set
            {
                this.title = title;
            }
        }

        // Setters
    }
}