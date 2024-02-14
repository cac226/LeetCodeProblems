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

