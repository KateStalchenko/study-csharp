//Write a function that takes an array of numbers(integers for the tests) and a target number.
//It should find two different items in the array that, when added together, give the target value. 
//The indices of these items should then be returned in an array like so: [index1, index2].
//For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.
//The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers;
//target will always be the sum of two different items from that array).

namespace Codewars.SumOfInteger
{
    class SumOfInteger
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            var result = new int[2];
            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        result[0] = j;
                        result[1] = i;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
