using System;

namespace BrokenMessage
{
    internal class BrokenMessage
    {
        private static void Main()
        {
            var brokenMessage = "h%e&·%$·llo w&%or&$l·$%d";
            brokenMessage = BrokenMessageRefactor(brokenMessage);
            Console.WriteLine(brokenMessage);
        }

        public static string BrokenMessageRefactor(string message)
        {
            message = message.Replace("%", "").Replace("$", "").Replace("&", "").Replace("/", "").Replace("#", "").Replace("|", "").Replace("@", "").Replace("\\", "").Replace("·", "").Replace("º", "").Replace("ª", "");
            return message;
        }
    }
}
