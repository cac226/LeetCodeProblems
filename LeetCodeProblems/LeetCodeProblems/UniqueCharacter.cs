using System;
namespace LeetCodeProblems
{
	public class UniqueCharacter
	{
		public static int FirstUniqueCharacter(string s)
		{
			Dictionary<char, int> letterIndexLookup = new Dictionary<char, int>();
			for(int i = 0; i < s.Length; i++)
			{
				char letter = s[i];

				if(letterIndexLookup.ContainsKey(letter))
				{
					letterIndexLookup[letter] = -1;
				} else
				{
					letterIndexLookup.Add(letter, i);
				}
			}

			List<char> distinctLetters = letterIndexLookup.Where(kvp => kvp.Value != -1)
													 .Select(kvp => kvp.Key)
													 .ToList();

			if(distinctLetters.Count == 0)
			{
                return -1;
            }
			int distinctLetterIndex = s.Length + 1;

			foreach(char letter in distinctLetters)
			{
				if (letterIndexLookup[letter] < distinctLetterIndex)
				{
					distinctLetterIndex = letterIndexLookup[letter];
                }
			}

			return distinctLetterIndex;
		}
	}
}

