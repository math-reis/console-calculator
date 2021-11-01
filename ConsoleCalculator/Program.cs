using System;
using static ConsoleCalculator.Message;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Welcome);
            View.DisplayScreen();
            Console.WriteLine(Line);
            Console.WriteLine(Bye);
            Console.ReadLine();
        }
    }
}
