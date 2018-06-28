using System;

namespace altERnaTIngcAsE
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine();
            phrase = ToAlternatingCase(phrase);
            Console.WriteLine(phrase);
            Console.ReadLine();
        }

        public static string ToAlternatingCase(string s)
        {
            char[] letters = s.ToCharArray();
            for (int i=0; i<s.Length; i++)
            {
                letters[i] = char.IsUpper(letters[i]) ? char.ToLower(letters[i]) : char.ToUpper(letters[i]);
            }
            s = new string (letters);
            return s;
        }
    }
}
