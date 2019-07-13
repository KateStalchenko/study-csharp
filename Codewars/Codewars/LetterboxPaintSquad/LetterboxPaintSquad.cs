/*
   Given the start and end letterbox numbers, write a method to return the frequency of all 
   10 digits painted.
   
   Example
   For start = 125, and end = 132
   
   The letterboxes are
   
   125 = 1, 2, 5
   126 = 1, 2, 6
   127 = 1, 2, 7
   128 = 1, 2, 8
   129 = 1, 2, 9
   130 = 1, 3, 0
   131 = 1, 3, 1
   132 = 1, 3, 2
   The digit frequencies are 1 x 0, 9 x 1, 6 x 2 etc...
   
   and so the method would return [1,9,6,3,0,1,1,1,1,1]
 */
using System.Collections.Generic;

namespace Codewars.LetterboxPaintSquad
{
    public class LetterboxPaintSquad
    {
        public IEnumerable<int> PaintLetterBoxes(int start, int end)
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
