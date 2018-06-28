using System;

namespace BrokenMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string brokenMessage = "h%e&·%$·llo w&%or&$l·$%d";
            brokenMessage = BrokenMessage(brokenMessage);
            Console.WriteLine(brokenMessage);
        }

        public static string BrokenMessage(string message)
        {
            message = message.Replace("%", "").Replace("$", "").Replace("&", "").Replace("/", "").Replace("#", "").Replace("|", "").Replace("@", "").Replace("\\", "").Replace("·", "").Replace("º", "").Replace("ª", "");
            return message;
        }
    }
}
