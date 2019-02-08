public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string inputLowerWithoutSpace = input.Replace(" ", "").ToLower();
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        foreach (char symbol in alphabet)
        {
            if (inputLowerWithoutSpace.Contains(symbol))
            {
                continue;
            }
            return false;
        }

        return true;
    }
}
