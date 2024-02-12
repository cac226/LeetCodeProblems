using System;
namespace LeetCodeProblems
{
    public class RemoveDuplicatesClass
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 3)
            {
                return nums.Length;
            }

            int duplicateNumbers = 0;
            int validNumbers = 0;

            for(int i = nums.Length - 1; i >= 2; i--)
            {
                if (nums[i] == nums[i - 1] && nums[i] == nums[i-2])
                {
                    for(int j = i; j < nums.Length - 1 - duplicateNumbers; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    duplicateNumbers++;
                } else
                {
                    validNumbers++;
                }
            }

            return validNumbers + 2;
        }
    }
}

