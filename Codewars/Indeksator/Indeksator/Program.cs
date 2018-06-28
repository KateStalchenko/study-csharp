using System;

namespace Indeksator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Sentence()[0]);
        }
    }

    class Sentence
    {
        string[] words = "The quick brown Fox".Split();

        public string this[int wordNum]
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
        }
    }
}


