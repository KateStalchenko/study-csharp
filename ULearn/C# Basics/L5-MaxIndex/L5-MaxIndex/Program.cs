//Написать метод поиска индекса максимального элемента.То есть такого числа i, что array[i] — это максимальное из чисел в массиве.
//Если в массиве максимальный элемент встречается несколько раз, вывести нужно минимальный индекс.
//Если массив пуст, вывести нужно -1.

using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxIndex(new double[] { 1, 2, 3 }));
            Console.WriteLine(MaxIndex(new double[] { }));
            Console.WriteLine(MaxIndex(new double[] { 1 }));
            Console.WriteLine(MaxIndex(new double[] { 0, 100, 1, 2, 100 }));
            Console.WriteLine(MaxIndex(new double[] { 1, 2, 3, 100, 4, 5, 6 }));
            Console.WriteLine(MaxIndex(new double[] { 100, 100, 100, 100 }));
        }

        public static int MaxIndex(double[] array)
        {
            if (array.Length == 0) return -1;
            List<double> list = array.ToList();
            int maxIndex = list.IndexOf(list.Max());
            return maxIndex;
        }
    }
}
