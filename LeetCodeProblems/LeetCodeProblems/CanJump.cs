using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    public class CanJump
	{
        /// <summary>
        /// You are given an integer array nums. You are initially
        /// positioned at the array's first index, and each element
        /// in the array represents your maximum jump length at that position.
        ///
        /// Return true if you can reach the last index, or false otherwise.
        /// 
        /// </summary>
        public static bool CanJumpToEnd(int[] nums)
		{
            Dictionary<int, bool> isIndexAccessible = new Dictionary<int, bool>()
            {
                { 0, true} // start at first space, so it's always accessible 
            };
            
            for(int n = 1; n < nums.Length; n++)
            {
                isIndexAccessible.Add(n, false);
            }

            int i = 0;

            while(i < nums.Length && isIndexAccessible[i])
            {
                int jumpDistanceFromPosition = nums[i];

                int maxJumpPosition = Math.Min(nums.Length - 1, i + jumpDistanceFromPosition);

                for(int j = i + 1; j <= maxJumpPosition; j++)
                {
                    isIndexAccessible[j] = true;
                }

                i++;
            }

            return isIndexAccessible[nums.Length - 1];
		}
	}
}

