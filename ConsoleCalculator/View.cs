using System;
using static ConsoleCalculator.Calculator;
using static ConsoleCalculator.Enumerator;
using static ConsoleCalculator.Message;

namespace ConsoleCalculator
{
    class View
    {
        public static void DisplayScreen()
        {
            Console.WriteLine(Line);
            Console.WriteLine(Addition);
            Console.WriteLine(Subtraction);
            Console.WriteLine(Multiplication);
            Console.WriteLine(Division);
            Console.WriteLine(Percentage);
            Console.WriteLine(Exponentiation);
            Console.WriteLine(Root);
            Console.WriteLine(Exit);
            Console.WriteLine(Line);
            Console.Write(Operation);

            try
            {
                Operator oper = (Operator)Convert.ToDouble(Console.ReadLine());

                while (oper != 0)
                {
                    if (oper > 0 && oper < (Operator)9)
                    {
                        Console.WriteLine(Line);
                        Console.Write(First);
                        double firstNum = Convert.ToDouble(Console.ReadLine());
                        Console.Write(Second);
                        double secondNum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Line);
                        Console.WriteLine(Result, oper, firstNum, secondNum, Calculate(firstNum, secondNum, oper));
                        Console.WriteLine(Line);
                    }
                    else
                    {
                        Console.WriteLine(Line);
                        Console.WriteLine(Invalid);
                        DisplayScreen();
                    }

                    while (oper != 0)
                    {
                        Console.Write(Continue);
                        string choice = Console.ReadLine().ToUpper();
                        if (choice == "Y")
                        {
                            Console.Clear();
                            DisplayScreen();
                            oper = 0;
                        }
                        else if (choice == "N")
                        {
                            oper = 0;
                        }
                        else
                        {
                            Console.WriteLine(Line);
                            Console.WriteLine(Invalid);
                            Console.WriteLine(Line);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Line);
                Console.WriteLine(Invalid);
                DisplayScreen();
            }
        }
    }
}
