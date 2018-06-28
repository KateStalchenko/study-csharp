using System;

namespace By_3_or_not_by_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            bool numberBool = DivisibleByThree(number);
            Console.WriteLine(numberBool);
            Console.ReadLine();
        }

        public static bool DivisibleByThree(string n)
        {
            int quantity = 0;
            foreach (char nChar in n)
            {
                int parsedChar = int.Parse(nChar.ToString());
                quantity += parsedChar;
            }
            return quantity % 3 == 0 ? true : false;
        }
    }
}
