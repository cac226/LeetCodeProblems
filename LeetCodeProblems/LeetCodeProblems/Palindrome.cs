using System;
namespace LeetCodeProblems
{
	public class Palindrome
	{
        public static string FirstPalindrome(string[] words)
        {
            foreach(string word in words)
            {
                if(isPalindrome(word))
                {
                    return word;
                }
            }

            return "";
        }

        private static bool isPalindrome(string str)
        {
            IEnumerable<char> strArr = str.ToCharArray();
            IEnumerable<char> reverseStr = str.Reverse();

            return Enumerable.SequenceEqual(strArr, reverseStr);
        }
    }
}

