using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var listOfWords = Regex.Split(phrase, @"[-\s\n_]+");
        return new string(listOfWords.Where(s => !string.IsNullOrEmpty(s))
            .Select(s => s[0])
            .Select(s => char.ToUpper(s))
            .Where(l => char.IsLetter(l))
            .ToArray());
    }
}