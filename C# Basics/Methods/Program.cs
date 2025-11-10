namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet("Jai");
            Console.ReadLine();
        }
        
        // create method
        static void Greet(string name)
        {
            Console.WriteLine("Hello "+ name);
        }
    }
}