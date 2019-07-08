using System;
using System.Linq;

namespace ReplaceWithAlphabetPosition
{
    class ReplaceWithAlphabetPosition
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var response = AlphabetPosition(text);
            Console.WriteLine(response);
            Console.ReadLine();
        }

        public static string AlphabetPosition(string text)
        {
            var letters = "abcdefghijklmnopqrstuvwxyz";
            var lettersOfAlphabet = letters.ToCharArray();
            text = text.ToLower();
            var charOfText = text.ToCharArray();
            var order = (from _char in charOfText select Array.IndexOf(lettersOfAlphabet, _char) into index where index >= 0 select index + 1).ToList();
            return string.Join(" ", order);
        }
    }
}