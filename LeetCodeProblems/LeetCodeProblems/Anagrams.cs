using System;
namespace LeetCodeProblems
{
	public class Anagrams
	{
        #region Group Anagrams
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> anagramLookup = new Dictionary<string, IList<string>>();

            foreach(string str in strs)
            {
                string alphabatizedString = alphabatizeCharacters(str);

                if(!anagramLookup.ContainsKey(alphabatizedString))
                {
                    anagramLookup.Add(alphabatizedString, new List<string>());
                }
                anagramLookup[alphabatizedString].Add(str);
            }

            return anagramLookup.Select(kvp => kvp.Value).ToList();
        }

        private static string alphabatizeCharacters(string str)
        {
            return String.Concat(str.OrderBy(c => c));
        }
        #endregion

        #region Valid Anagram

        public static bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }

            char[] sArr = s.ToCharArray();
            char[] tArr = t.ToCharArray();

            Array.Sort(sArr);
            Array.Sort(tArr);

            return sArr.SequenceEqual(tArr);
        }

        #endregion
    }
}

