/* Напишите метод Min, который бы вычислял минимум из элементов массива. */

using System;

namespace L13_FindTheMinimum
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
            Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
            Console.WriteLine(Min(new[] { '4', '2', '7' }));
        }

        public static object Min(Array arr)
        {
            Array.Sort(arr);
            return arr.GetValue(0);
        }
    }
}
