//Welcome.
//In this kata you are required to, given a string, replace every letter with its position in the alphabet.
//If anything in the text isn't a letter, ignore it and don't return it.
//a being 1, b being 2, etc.

using System;
using System.Collections.Generic;

namespace ReplaceWithAlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string text2 = Console.ReadLine();
            string response = AlphabetPosition(text2);
            Console.WriteLine(response);
            Console.ReadLine();
        }

        public static string AlphabetPosition(string text)
        {
            int indx;
            List<int> order = new List<int>();
            string letters = "abcdefghijklmnopqrstuvwxyz";
            char[] lettersOfAlphabet = letters.ToCharArray();
            text = text.ToLower();
            char[] charOfText = text.ToCharArray();
            for (int j = 0; j < charOfText.Length; j++)
            {
                indx = Array.IndexOf(lettersOfAlphabet, charOfText[j]);
                if (indx >=0)
                {
                    order.Add(indx + 1);
                }
            }
            return String.Join(" ", order);
        }
    }
}