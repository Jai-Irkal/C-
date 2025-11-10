namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello this is an " + "Example string";
            Console.WriteLine(text);
            // Length of string
            Console.WriteLine(text.Length);
            // UpperCase
            Console.WriteLine(text.ToUpper());
            // LowerCase
            Console.WriteLine(text.ToLower());
            // Check substring exists
            Console.WriteLine(text.Contains("Hello"));
            // Check index of existing substring
            Console.WriteLine(text.IndexOf("this")); // If not exists -1
            
        }
    }
}