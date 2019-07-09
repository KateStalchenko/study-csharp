namespace Codewars.Indeksator
{
    public class Indeksator
    {
    }

    public class Sentence
    {
        private readonly string[] _words = "The quick brown Fox".Split();

        public string this[int wordNum]
        {
            get => _words[wordNum];
            set => _words[wordNum] = value;
        }
    }
}

