using NUnit.Framework;
using System.Linq;

namespace Codewars.Tests
{
    [TestFixture]
    public class CodewarsTest
    {
        [TestCase("AaBb", "aAbB")]
        [TestCase("BBBaaa", "bbbAAA")]
        public void AltERnaTIngcAsETest(string phrase, string expectedResult)
        {
            phrase = new AltERnaTIngcAsE.AltERnaTIngcAsE().ToAlternatingCase(phrase);
            Assert.AreEqual(expectedResult, phrase);
        }

        [TestCase("h%e&·%$·llo w&%or&$l·$%d", "hello world")]
        public void BrokenMessage(string brokenMessage, string expectedMessage)
        {
            var repairMessage = new BrokenMessage.BrokenMessage().BrokenMessageRefactor(brokenMessage);
            Assert.AreEqual(expectedMessage, repairMessage);
        }

        [TestCase("17", false)]
        public void By3OrNotBy3(string number, bool expectedResult)
        {
            var numberBool = new By_3_or_not_by_3.By3OrNotBy3().DivisibleByThree(number);
            Assert.AreEqual(expectedResult, numberBool);
        }

        [TestCase("elephant", "eggplant", true)]
        public void FeastOfManyBeasts(string beast, string dish, bool expectedResult)
        {
            var result = new FeastOfManyBeasts.FeastOfManyBeasts().Feast(beast, dish);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(125, 132, new[] { 1, 9, 6, 3, 0, 1, 1, 1, 1, 1 })]
        public void LetterBoxPaintSquad(int startNumber, int endNumber, int[] expectedResult)
        {
            var array = new LetterboxPaintSquad.LetterboxPaintSquad().PaintLetterBoxes(startNumber, endNumber).ToArray();
            Assert.AreEqual(expectedResult, array);
        }

        [TestCase("Text Test", "20 5 24 20 20 5 19 20")]
        public void ReplaceWithAlphabetPosition(string text, string expectedResult)
        {
            var response = new ReplaceWithAlphabetPosition.ReplaceWithAlphabetPosition().AlphabetPosition(text);
            Assert.AreEqual(expectedResult, response);
        }

        [TestCase(new[] { 2, 2, 3 }, 4, new[] { 0, 1 })]
        public void SumOfInteger(int[] numbers, int target, int[] expectedResult)
        {
            var sum = new SumOfInteger.SumOfInteger().TwoSum(numbers, target);
            Assert.AreEqual(expectedResult, sum);
        }
    }
}
