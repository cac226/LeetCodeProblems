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

        // supports 0 < num <= 3999
        public static string IntToRoman(int num)
        {
            string result = "";

            return result;
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

