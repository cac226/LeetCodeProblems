using System;
namespace LeetCodeProblems
{
	public class PhoneNumbers
	{
        private static readonly Dictionary<int, char[]> DIGIT_TO_LETTER_PHONE_NUMBER =
            new Dictionary<int, char[]>()
            {
                {2, new char[] {'a', 'b', 'c' } },
                {3, new char[] {'d', 'e', 'f'} },
                {4, new char[] {'g', 'h', 'i' } },
                {5, new char[] {'j', 'k', 'l'} },
                {6, new char[] {'m', 'n', 'o'} },
                {7, new char[] {'p', 'q', 'r', 's'} },
                {8, new char[] {'t', 'u', 'v'} },
                {9, new char[] {'w', 'x', 'y', 'z'} }
            };

        /// <summary>
        /// Given a string containing digits from 2-9 inclusive, return all
        /// possible letter combinations that the number could represent.
        /// Return the answer in any order.
        /// </summary>
        public static IList<string> LetterCombinations(string digits)
        {
            if(digits == "")
            {
                return new List<string>();
            }
            return addLetters(digits, 0);
        }

        private static IList<string> addLetters(string digits, int index)
        {
            if(digits.Length == index)
            {
                return new List<string>() { "" };
            }
            int firstDigit = Int32.Parse(digits[index] + "");
            char[] possibleFirstLetter = DIGIT_TO_LETTER_PHONE_NUMBER[firstDigit];

            IList<string> otherLetters = addLetters(digits, index + 1);
            List<string> result = new List<string>();

            foreach(char letter in possibleFirstLetter)
            {
                foreach(string otherLetter in otherLetters)
                {
                    result.Add(letter + otherLetter);
                }
            }

            return result;
        }
    }
}

