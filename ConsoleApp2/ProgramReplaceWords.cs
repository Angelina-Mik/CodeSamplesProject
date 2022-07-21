using System;

namespace ConsoleApp2
{
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
}

