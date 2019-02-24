public static class TwoFer
{
    public static string Name(string input = null)
    {
        string text = "One for you, one for me.";

        if (input == null)
        {
            return text;
        }
        return text.Replace("you", input);
    }
}
