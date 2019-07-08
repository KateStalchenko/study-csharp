using System;

namespace By_3_or_not_by_3
{
    class By_3_or_not_by_3
    {
        private static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var numberBool = DivisibleByThree(number);
            Console.WriteLine(numberBool);
            Console.ReadLine();
        }

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
