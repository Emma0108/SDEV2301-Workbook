namespace HelloWorldConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, Visual Studio World!");
            Console.Write(" this continutes on the same line without adding new line");
            Console.WriteLine();
            Console.WriteLine("Write text and create a 2nd line");
            Console.WriteLine("Line 1\nLine 2\nLine 3\n"); // using escape sequence for new line
            Console.WriteLine("""
                Line 1
                Line 2
                Line 3
                """); // using raw string literal for multiline text (useful for multiselect menus)
        }
    }
}
