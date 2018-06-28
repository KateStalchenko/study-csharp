using System;

namespace L2_Practice_Percent
{
    class Program
    {
        static void Main(string[] args)
        {
            string userValues = Console.ReadLine();
            decimal result = Calculate(userValues);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static decimal Calculate(string userInput)
        {
            string[] values = userInput.Split(' ');
            decimal sum = decimal.Parse(values[0]);
            decimal percent = decimal.Parse(values[1]);
            int termOftTheDeposit = int.Parse(values[2]);

            for (int i = 0; i < termOftTheDeposit; i++)
            {
                sum = sum + ((sum * percent) / 100) / 12;
            }
            return sum;
        }
    }
}
