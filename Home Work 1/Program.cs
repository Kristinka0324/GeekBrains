using System;

namespace Home_Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();
            Console.WriteLine($"[{DateTime.Now}] Hello, {name}!");

        }
    }
}
