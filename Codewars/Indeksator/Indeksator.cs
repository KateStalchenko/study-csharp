using System;

namespace Indeksator
{
    class Indeksator
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Sentence()[0]);
        }
    }

    class Sentence
    {
        private readonly string[] words = "The quick brown Fox".Split();

        public string this[int wordNum]
        {
            get => words[wordNum];
            set => words[wordNum] = value;
        }
    }
}

