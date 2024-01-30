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
            if (nums.Length <= 1)
            {
                return true;
            }

            int targetIndex = nums.Length - 1;

            for(int i = nums.Length - 2; i >= 0; i--)
            {
                if (targetIndex <= nums[i] + i)
                {
                    targetIndex = i;
                }
            }

            return targetIndex == 0;
		}
	}
}

