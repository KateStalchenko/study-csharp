namespace Codewars.AltERnaTIngcAsE
{
    public class AltERnaTIngcAsE
    {
        public string ToAlternatingCase(string s)
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
