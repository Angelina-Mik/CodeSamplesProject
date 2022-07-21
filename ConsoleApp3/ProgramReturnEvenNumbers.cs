using System;

namespace ConsoleApp3
{
    class ProgramReturnEvenNumbers
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ReturnEvenNum());
            Console.ReadLine();
        }

        static string ReturnEvenNum()
        {
            string evenNumbers = string.Empty;

            for (int i = 1; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers += i + "\n";
                }
            }
            return evenNumbers;
        }
    }
}

