using System;
namespace LeetCodeProblems
{
    public class RomanNumerals
    {
        /*
         *  I             1
            V             5
            X             10
            L             50
            C             100
            D             500
            M             1000
         */

        private static readonly Dictionary<char, int> NUMERALS_TO_VAL =
            new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

        private static readonly Dictionary<int, string> VALS_TO_NUMERALS =
            new Dictionary<int, string>()
            {
                {1, "I"},
                {4, "IV" },
                {5, "V" },
                {9, "IX" },
                {10, "X" },
                {40, "XL" },
                {50, "L" },
                {90, "XC" },
                {100, "C"},
                {400, "CD" },
                {500, "D"},
                {900, "CM" },
                {1000, "M"}
            };

        private static readonly List<int> VALS_WITH_NUMERALS_DESCENDING = VALS_TO_NUMERALS.Keys
            .OrderDescending()
            .ToList();

        // supports 0 < num <= 3999
        public static string IntToRoman(int num)
        {
            if(num <= 0 || 4000 <= num)
            {
                return "";
            }

            string result = intToRomanRecursive(num);

            return result;
        }

        private static string intToRomanRecursive(int num)
        {
            if(num == 0)
            {
                return "";
            }

            int greatestNumeral = VALS_WITH_NUMERALS_DESCENDING.First(x => x <= num);

            return VALS_TO_NUMERALS[greatestNumeral] + intToRomanRecursive(num - greatestNumeral);
        }

        public static int RomanToInt(string s)
        {
            int total = 0;

            for(int i = 0; i < s.Length; i++)
            {
                int val = NUMERALS_TO_VAL[s[i]];

                if(i + 1 < s.Length &&
                    val < NUMERALS_TO_VAL[s[i + 1]])
                {
                    total -= val;
                } else
                {
                    total += val;
                }
            }

            return total;
        }
    }
}

