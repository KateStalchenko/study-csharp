/* 
 * You are given an array (which will have a length of at least 3, but could be very large) containing integers. 
 * The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. 
 * Write a method that takes the array as an argument and returns this "outlier" N.
 * Examples
 * [2, 4, 0, 100, 4, 11, 2602, 36] Should return: 11 (the only odd number)
 * [160, 3, 1719, 19, 11, 13, -21] Should return: 160 (the only even number)
 */

using System.Collections.Generic;

namespace FindTheParityOutlier
{
    internal class FindTheParityOutlier
    {
        private static void Main(string[] args)
        {
            var response = Kata.Find(new[] { 5, 7, 13, 8, 21, 17 });
        }
    }


    public class Kata
    {
        public static int Find(int[] integers)
        {
            var evenNumbers = new List<int>();
            var oddNumbers = new List<int>();

            foreach (var number in integers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Add(number);
                }
            }

            return evenNumbers.Count == 1 ? evenNumbers[0] : oddNumbers[0];
        }
    }
}