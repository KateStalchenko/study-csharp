/*
 You have an array of numbers.
   Your task is to sort ascending odd numbers but even numbers must be on their places.
   
   Zero isn't an odd number and you don't need to move it. If you have an empty array, you need to return it.
 */

using System.Linq;

namespace Codewars.SortTheOdd
{
    class SortTheOdd
    {
        public int[] SortArray(int[] array)
        {
            if (array.Length == 0)
            {
                return array;
            }

            var oddNumbers = array.Where(number => number % 2 != 0).ToList();

            oddNumbers = oddNumbers.OrderBy(n => n).ToList();
            var index = 0;

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] = oddNumbers[index];
                    index++;
                }
            }
            return array;
        }
    }
}
