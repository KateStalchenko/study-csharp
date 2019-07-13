/* Simple, remove the spaces from the string, then return the resultant string. */

namespace Codewars.RemoveStringSpaces
{
    public class RemoveStringSpaces
    {
        public string NoSpace(string input)
        {
            var newInput = input.Replace(" ", "");
            return newInput;
        }
    }
}