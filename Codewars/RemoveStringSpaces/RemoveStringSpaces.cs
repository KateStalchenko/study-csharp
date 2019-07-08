/* Simple, remove the spaces from the string, then return the resultant string. */
using System;

namespace RemoveStringSpaces
{
    internal class RemoveStringSpaces
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            text = NoSpace(text);
            Console.WriteLine(text);
        }

        public static string NoSpace(string input)
        {
            var newInput = input.Replace(" ", "");
            return newInput;
        }
    }
}