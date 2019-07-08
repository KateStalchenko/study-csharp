using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterboxPaintSquad
{
    internal class LetterboxPaintSquad
    {
        static void Main(string[] args)
        {
            var array = PaintLetterBoxes(125, 132).ToArray();
            Console.WriteLine(string.Join(" ", array));
        }

        public static IEnumerable<int> PaintLetterBoxes(int start, int end)
        {
            var arr = new int[end - start + 1];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = start + i;
            }
            var stringArr = string.Join("", arr);
            var arrReturn = new int[10];
            foreach (var arrChar in stringArr)
            {
                arrReturn[int.Parse(arrChar.ToString())]++;
            }
            return arrReturn;
        }
    }
}
