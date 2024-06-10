using System;
namespace LeetCodeProblems
{
	public class StringMatching
	{
        /*
         Two strings are considered close if you can attain one from the other
        using the following operations:

        Operation 1: Swap any two existing characters.
            For example, abcde -> aecdb

        Operation 2: Transform every occurrence of one existing character
        into another existing character, and do the same with the other character.
            For example, aacabb -> bbcbaa (all a's turn into b's, and all b's
            turn into a's)

        You can use the operations on either string as many times as necessary.

        Given two strings, word1 and word2, return true if word1 and word2 are
        close, and false otherwise.

        
        1 <= word1.length, word2.length <= 10^5
        word1 and word2 contain only lowercase English letters.

         */
        public static bool CloseStrings(string word1, string word2)
        {
            if(word1.Length != word2.Length)
            {
                return false;
            }

            int[] letterCount1 = new int[26];
            int[] letterCount2 = new int[26];

            for(int i = 0; i < word1.Length; i++)
            {
                int letter1Index = word1[i] - 'a';
                int letter2Index = word2[i] - 'a';
                letterCount1[letter1Index]++;
                letterCount2[letter2Index]++;
            }

            List<int> mismatched1 = new List<int>();
            List<int> mismatched2 = new List<int>();


            for(int i = 0; i < letterCount1.Length; i++)
            {
                int count1 = letterCount1[i];
                int count2 = letterCount2[i];
                if (count1 != count2)
                {
                    if (count1 == 0 || count2 == 0)
                    {
                        return false;
                    }

                    mismatched1.Add(count1);
                    mismatched2.Add(count2);
                }
            }

            return Enumerable.SequenceEqual(mismatched1.Order(), mismatched2.Order());
        }
    }
}

//aaabbbbccddeeeeefffff
//aaaaabbcccdddeeeeffff

