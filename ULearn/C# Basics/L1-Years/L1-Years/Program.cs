//Найти количество високосных лет на отрезке[a, b]

using System;

namespace Years
{
    class Years
    {
        static void Main(string[] args)
        {
            int quantity = 0;
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int[] years = new int[end - start + 1];
            for (int i = 0; i < years.Length; i++)
            {
                years[i] = start + i;
                if (years[i] % 4 == 0)
                {
                    quantity += 1;
                }
            }
            Console.WriteLine(quantity);

        }
    }
}