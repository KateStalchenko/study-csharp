/* In this kata you have to write a simple Morse code decoder. While the Morse code is now mostly superceded by voice and digital data 
 * communication channels, it still has its use in some applications around the world.
 * The Morse code encodes every character as a sequence of "dots" and "dashes". 
 * NOTE: Extra spaces before or after the code have no meaning and should be ignored.
 * Your task is to implement a function that would take the morse code as input and return a decoded human-readable string.
 * For example:
 * MorseCodeDecoder.Decode(".... . -.--   .--- ..- -.. .") should return "HEY JUDE"
 * The Morse code table is preloaded for you as a dictionary, feel free to use it:
 * C#: MorseCode.Get(".--") (returns string)
 * All the test strings would contain valid Morse code, so you may skip checking for errors and exceptions. 
 * In C#, tests will fail if the solution code throws an exception, please keep that in mind. 
 * This is mostly because otherwise the engine would simply ignore the tests, resulting in a "valid" solution.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Codewars.DecodeTheMorseCodePart1
{
    public class MorseCodeDecoder
    {
        public string Decode(string morseCode)
        {
            const string wordSeparator = "   ";
            const string letterSeparator = " ";

            var morseCodeWords = new List<string>();
            var result = new StringBuilder();

            morseCode = morseCode.Trim();
            morseCodeWords = Regex.Split(morseCode, wordSeparator).ToList();
            foreach (var word in morseCodeWords)
            {
                var arrTemp = Regex.Split(word, letterSeparator);
                foreach (var encodedWord in arrTemp)
                {
                    result.Append(MorseCode.Get(encodedWord));
                }
                result.Append(" ");
            }
            var response = result.ToString().TrimEnd();
            return response;
        }
    }

    internal class MorseCode
    {
        internal static char Get(string encodedWord)
        {
            throw new NotImplementedException(); // Original method was in kata
        }
    }
}
