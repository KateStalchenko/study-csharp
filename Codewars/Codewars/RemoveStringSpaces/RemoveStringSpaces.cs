/* Simple, remove the spaces from the string, then return the resultant string. */

namespace Codewars.RemoveStringSpaces
{
    internal class RemoveStringSpaces
    {
        public static string NoSpace(string input)
        {
            var newInput = input.Replace(" ", "");
            return newInput;
        }
    }
}