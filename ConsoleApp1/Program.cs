using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            char[] message1 = { 'a', 'a', 'b', 'a', 'a' };
            
            foreach (char letter in message1)
            {
                if (letter.Equals('a'))
                {
                    Console.WriteLine(")");
                }
                else if (letter.Equals('b'))
                { 
                    Console.WriteLine("(");
                }
            }

            Console.ReadLine();
        }
    }
    class ProgramReplaceWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceWords("Support_Ukraine", '_'));
            Console.WriteLine(ReplaceWords("Stand-ForUkraine", '-'));
            Console.WriteLine(ReplaceWords("Be.Ukrainian", '.'));
            Console.ReadLine();
        }
        public static string ReplaceWords(string word, char ch)
        {
            string word1 = string.Empty;
            string word2 = string.Empty;

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] != ch)
                {
                    word2 += word[i];
                }
                else
                {
                    for (int j = i + 1; j <= word.Length - 1; j++)
                    {
                        word1 += word[j];
                    }
                    break;
                }

            }
            return word1 + ch + word2;
        }
    }

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

    class ProgramSimpeCulculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter number 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Incorrect operator");
            }
        }

    }
}

