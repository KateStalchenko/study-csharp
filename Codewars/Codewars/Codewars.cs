using System;
using System.Linq;

namespace Codewars
{
    internal class Codewars
    {
        private static void Main(string[] args)
        {
            // AltERnaTIngcAsE Task
            var phrase = Console.ReadLine();
            phrase = AltERnaTIngcAsE.AltERnaTIngcAsE.ToAlternatingCase(phrase);
            Console.WriteLine(phrase);

            // BrokenMessage Task
            var brokenMessage = "h%e&·%$·llo w&%or&$l·$%d";
            brokenMessage = BrokenMessage.BrokenMessage.BrokenMessageRefactor(brokenMessage);
            Console.WriteLine(brokenMessage);

            // By3OrNotBy3 Task
            var number = Console.ReadLine();
            var numberBool = By_3_or_not_by_3.By3OrNotBy3.DivisibleByThree(number);
            Console.WriteLine(numberBool);

            // FeastOfManyBeasts Task
            var beast = "elephant";
            var dish = "eggplant";
            var result = FeastOfManyBeasts.FeastOfManyBeasts.Feast(beast, dish);

            // LetterboxPaintSquad Task
            var array = LetterboxPaintSquad.LetterboxPaintSquad.PaintLetterBoxes(125, 132).ToArray();
            Console.WriteLine(string.Join(" ", array));

            // ReplaceWithAlphabetPosition Task
            var text = Console.ReadLine();
            var response = ReplaceWithAlphabetPosition.ReplaceWithAlphabetPosition.AlphabetPosition(text);
            Console.WriteLine(response);

            // SumOfInteger Task
            int[] numbers = { 2, 2, 3 };
            const int target = 4;
            var sum = SumOfInteger.SumOfInteger.TwoSum(numbers, target);
            Console.WriteLine(string.Join(",", sum));
        }
    }
}
