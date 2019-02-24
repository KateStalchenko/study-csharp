using System.Collections.Generic;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        List<char> lettersAsList = new List<char>();
        lettersAsList.AddRange(word);

        var duplicateLetters = lettersAsList
            .GroupBy(x => x)
            .Where(g => g.Count() > 1)
            .Select(y => y.Key)
            .ToList();

        return duplicateLetters.Count() > 0;
    }
}
