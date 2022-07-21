using System;

namespace ConsoleApp1
{
    class ProgramReplaceCharacters
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
}

