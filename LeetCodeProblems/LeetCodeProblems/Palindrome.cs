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
            int[] asciiOccurances = new int[128];

            foreach(char c in s)
            {
                asciiOccurances[c]++;
            }

            int length = 0;
            bool hasSpareChar = s.Length % 2 == 1;

            foreach(int letterCount in asciiOccurances)
            {
                if(letterCount % 2 == 0) // even # of occurances
                {
                    length += letterCount;
                } else // odd # of occurances 
                {
                    length += letterCount - 1;
                    hasSpareChar = true;
                }
            }

            if(hasSpareChar)
            {
                length++;
            }

            return length;
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

