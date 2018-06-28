using System;
using System.Linq;
using System.Collections.Generic;

namespace LetterboxPaintSquad
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = PaintLetterBoxes(125, 132).ToArray();
            Console.WriteLine(string.Join(" ", array));
        }

        public static IEnumerable<int> PaintLetterBoxes(int start, int end)
        {
            int[] arr = new int[end - start + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = start + i;
            }
            string stringArr = String.Join("", arr);
            int[] arrReturn = new int[10];
            foreach (char arrChar in stringArr)
            {
                arrReturn[int.Parse(arrChar.ToString())]++;
            }
            return arrReturn;
        }
    }
}
