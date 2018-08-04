/* Реализуйте метод Combine, который возвращает массив, собранный из переданных массивов.
Для того, чтобы создать новый массив, используйте статический метод Array.CreateInstance, принимающий тип элемента массива.
Для того, чтобы узнать тип элементов в переданном массиве, используйте myArray.GetType().GetElementType().
Проверьте, что типы элементов совпадают во всех переданных массивах!
Если результирующий массив создать нельзя, возвращайте null. */

using System;

namespace L13_MergingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new[] { 1, 2 };
            var strings = new[] { "A", "B" };

            Print(Combine(ints, ints));
            Print(Combine(ints, ints, ints));
            Print(Combine(ints));
            Print(Combine());
            Print(Combine(strings, strings));
            Print(Combine(ints, strings));
        }

        static void Print(Array array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array.GetValue(i));
            Console.WriteLine();
        }

        static Array Combine(params Array[] arrays)
        {
            int summaryLength = 0;
            foreach (var array in arrays)
            {
                if (array.GetType().GetElementType() != arrays[0].GetType().GetElementType()) return null;
                summaryLength += array.Length;
            }
            try
            {
                var result = Array.CreateInstance(arrays[0].GetType().GetElementType(), summaryLength);
                int index = 0;
                for (int i = 0; i < arrays.Length; i++)
                {
                    Array.Copy(arrays[i], 0, result, index, arrays[i].Length);
                    index += arrays[i].Length;
                }
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
