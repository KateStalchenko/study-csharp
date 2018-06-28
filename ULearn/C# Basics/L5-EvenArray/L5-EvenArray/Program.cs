//Напишите метод, который создает массив из count первых четных чисел больших нуля, в порядке возрастания.

using System;

namespace L5_EvenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", GetFirstEvenNumbers(21)));
        }

        public static int[] GetFirstEvenNumbers(int count)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 2 + 2;
            }
            return numbers;
        }
    }
}
