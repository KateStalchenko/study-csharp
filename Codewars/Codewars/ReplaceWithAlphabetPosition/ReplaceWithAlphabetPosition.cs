using System;
using System.Linq;

namespace Codewars.ReplaceWithAlphabetPosition
{
    public class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            const string letters = "abcdefghijklmnopqrstuvwxyz";
            var lettersOfAlphabet = letters.ToCharArray();
            text = text.ToLower();
            var charOfText = text.ToCharArray();
            var order = (from _char in charOfText select Array.IndexOf(lettersOfAlphabet, _char) into index where index >= 0 select index + 1).ToList();
            return string.Join(" ", order);
        }
    }
}