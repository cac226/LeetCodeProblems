using System;
namespace LeetCodeProblems
{
	public class Palindrome
	{
        /// <summary>
        /// Given a string s which consists of lowercase or uppercase letters,
        /// return the length of the longest palindrome that can be built with
        /// those letters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LongestPalindrome(string s)
        {
            if(s.Length <= 1)
            {
                return s.Length;
            }

            string sSorted = String.Concat(s.OrderBy(c => c));

            int charPairCount = 0;
            bool hasSpareChar = s.Length % 2 == 1;

            int index = 0;
            while(index < sSorted.Length)
            {
                char c = sSorted[index];
                int lastIndex = sSorted.LastIndexOf(c);
                int occurances = lastIndex - index + 1;
                charPairCount += occurances / 2;
                if(!hasSpareChar && occurances % 2 == 1)
                {
                    hasSpareChar = true;
                }
                index += occurances;
            }

            return (charPairCount * 2) + (hasSpareChar ? 1 : 0);
        }

        public static string FirstPalindrome(string[] words)
        {
            foreach(string word in words)
            {
                if(isPalindrome(word))
                {
                    return word;
                }
            }

            return ""; // no palindrome found in array, return empty string
        }

        private static bool isPalindrome(string str)
        {
            for(int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

