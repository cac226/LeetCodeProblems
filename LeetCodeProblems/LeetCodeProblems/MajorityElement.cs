using System;
namespace LeetCodeProblems
{
	public class MajorityElement
	{
        /*
		 Given an array nums of size n, return the majority element.

		The majority element is the element that appears more than ⌊n / 2⌋ times.
		You may assume that the majority element always exists in the array.
		 */
        public static int FindMajorityElement(int[] nums)
        {
			Dictionary<int, int> numToFrequency = new Dictionary<int, int>();
			int majorityElementFrequencyMinimum = (nums.Length / 2) + 1;

			for(int i = 0; i < nums.Length; i++)
			{
				if (!numToFrequency.ContainsKey(nums[i]))
				{
					numToFrequency.Add(nums[i], 1);
				} else {
                    numToFrequency[nums[i]]++;
                }

				if (numToFrequency[nums[i]] >= majorityElementFrequencyMinimum)
				{
					return nums[i];
				}
			}

			return -1;
        }    
	}
}

