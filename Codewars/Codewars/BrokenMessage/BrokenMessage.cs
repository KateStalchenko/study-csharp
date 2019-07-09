namespace Codewars.BrokenMessage
{
    public class BrokenMessage
    {
        public static string BrokenMessageRefactor(string message)
        {
            message = message.Replace("%", "").Replace("$", "").Replace("&", "").Replace("/", "").Replace("#", "").Replace("|", "").Replace("@", "").Replace("\\", "").Replace("·", "").Replace("º", "").Replace("ª", "");
            return message;
        }
    }
}
