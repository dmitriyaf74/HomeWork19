namespace HomeWork19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Программа 1");
            Console.ResetColor();
            Console.WriteLine("");
            Program1.Execute();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Программа 2");
            Console.ResetColor();
            Console.WriteLine("");
            Program2.Execute();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Программа 3");
            Console.ResetColor();
            Console.WriteLine("");
            Program3.Execute();
        }
    }
}
