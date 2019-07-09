namespace Codewars.By_3_or_not_by_3
{
    public class By3OrNotBy3
    {
        public static bool DivisibleByThree(string n)
        {
            var quantity = 0;
            foreach (var nChar in n)
            {
                var parsedChar = int.Parse(nChar.ToString());
                quantity += parsedChar;
            }
            return quantity % 3 == 0;
        }
    }
}
