using System.Collections.Generic;

namespace Codewars.LetterboxPaintSquad
{
    internal class LetterboxPaintSquad
    {
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
