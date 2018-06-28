//Помогите Васе написать метод, который принимает массив int[], возводит все его элементы в заданную степень и возвращает массив 
//с результатом этой операции.
//Исходный массив при этом должен остаться неизменным.

using System;

namespace ArrayInPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintArray(GetPoweredArray(arrayToPower, 1));
            PrintArray(GetPoweredArray(arrayToPower, 2));
            PrintArray(GetPoweredArray(arrayToPower, 3));
            PrintArray(GetPoweredArray(new int[0], 1));
            PrintArray(GetPoweredArray(new[] { 42 }, 0));
            Console.ReadKey();
        }

        public static int[] GetPoweredArray(int[] arr, int power)
        {
            //arr = new int[arr.Length];
            int[] array = new int[arr.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)Math.Pow(arr[i], power);
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            Console.WriteLine(String.Join(" ", array));
        }
    }
}