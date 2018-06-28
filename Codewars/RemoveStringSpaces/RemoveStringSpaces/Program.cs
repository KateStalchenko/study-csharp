/* Simple, remove the spaces from the string, then return the resultant string. */

using System;

namespace RemoveStringSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = NoSpace(text);
            Console.WriteLine(text);
        }

        public static string NoSpace(string input)
        {
            string newInput = input.Replace(" ", "");
            return newInput;
        }
    }
}