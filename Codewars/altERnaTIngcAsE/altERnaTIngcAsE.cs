using System;

namespace altERnaTIngcAsE
{
    internal class altERnaTIngcAsE
    {
        private static void Main(string[] args)
        {
            var phrase = Console.ReadLine();
            phrase = ToAlternatingCase(phrase);
            Console.WriteLine(phrase);
            Console.ReadLine();
        }

        public static string ToAlternatingCase(string s)
        {
            var letters = s.ToCharArray();
            for (var i = 0; i < s.Length; i++)
            {
                letters[i] = char.IsUpper(letters[i]) ? char.ToLower(letters[i]) : char.ToUpper(letters[i]);
            }
            s = new string(letters);
            return s;
        }
    }
}
