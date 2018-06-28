//Попробуйте найти в массиве не один элемент, а целый подмассив!
//Если подмассив найден в массиве, то вернуть нужно минимальный индекс, с которого начинается подмассив в исходном массиве.
//Например, поиск подмассива "3,4" в массиве "1,2,3,4,3,4" должен вернуть 2.
//Более строго это можно записать, если обозначить массив array, а подмассив subarray: функция должна вернуть такое минимальное k, 
//что array[k + i] == subarray[i] для всех i от 0 до subarray.Length-1.
//Если подмассив не найден, то вернуть нужно -1.
//  Считайте, что пустой подмассив содержится в любом массиве, начиная с индекса 0.

using System;

namespace ArrayInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindSubarrayStartIndex(new[] { 100, 100, 100, 100 }, new[] { 100, 100 }));
            Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3 }, new[] { 2 }));
            Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3 }, new[] { 2, 3 }));
            Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3 }, new[] { 1, 2 }));
            Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
            Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3 }, new[] { 1, 3 }));
            Console.WriteLine(FindSubarrayStartIndex(new[] { 1 }, new[] { 1, 2, 3 }));
            Console.WriteLine(FindSubarrayStartIndex(new int[0], new[] { 1, 2, 3 }));
            Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 3 }, new int[0]));
            Console.WriteLine(FindSubarrayStartIndex(new[] { 1, 2, 1, 2, 3 }, new[] { 1, 2, 3 }));
            Console.WriteLine(FindSubarrayStartIndex(new int[0], new int[0]));
        }

        public static int FindSubarrayStartIndex(int[] array, int[] subArray)
        {
            for (int i = 0; i < array.Length - subArray.Length + 1; i++)
                if (ContainsAtIndex(array, subArray, i)) return i;
            return -1;
        }

        public static bool ContainsAtIndex(int[] array, int[] subArray, int position)
        {
            for (int subPosition = 0; subPosition < subArray.Length; position++, subPosition++)
            {
                if (array[position] != subArray[subPosition])
                {
                    return false;
                }
            }
            return true;
        }
    }
}