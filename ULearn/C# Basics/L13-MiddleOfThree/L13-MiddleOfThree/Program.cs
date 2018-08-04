/* Помните задачу "Среднее трех"? Пришло время повторить ее для общего случая! */

using System;

namespace L13_MiddleOfThree
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(MiddleOfThree(2, 5, 4));
            Console.WriteLine(MiddleOfThree(3, 1, 2));
            Console.WriteLine(MiddleOfThree(3, 5, 9));
            Console.WriteLine(MiddleOfThree("B", "Z", "A"));
            Console.WriteLine(MiddleOfThree(3.45, 2.67, 3.12));
        }

        static IComparable MiddleOfThree(IComparable a, IComparable b, IComparable c)
        {
            if ((b.CompareTo(a) <= 0 && a.CompareTo(c) <= 0) || (c.CompareTo(a) <= 0 && a.CompareTo(b) <= 0))
                return a;
            else if ((a.CompareTo(b) <= 0 && b.CompareTo(c) <= 0) || (c.CompareTo(b) <= 0 && b.CompareTo(a) <= 0))
                return b;
            else
                return c;
        }


        //static IComparable MiddleOfThree(IComparable a, IComparable b, IComparable c)
        //{
        //    IComparable[] arr = { a, b, c };
        //    Array.Sort(arr);
        //    return arr[1];
        //}
    }
}
