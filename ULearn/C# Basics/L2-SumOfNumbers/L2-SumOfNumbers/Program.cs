/* Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5 */

using System;

namespace L2_SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
