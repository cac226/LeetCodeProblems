using System;
namespace LeetCodeProblems
{
	public class MissingNumberClass
	{
        /// <summary>
        /// Given an array nums containing n distinct numbers in the range
        /// [0, n], return the only number in the range that is missing
        /// from the array.
        /// </summary>
        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length;

            bool[] exists = new bool[n + 1];

            foreach(int num in nums)
            {
                exists[num] = true;
            }

            int missingNum = Array.FindIndex(exists, x => x == false);

            return missingNum;
        }
    }
}

