using System;
namespace LeetCodeProblems
{
	public class MedianSortedArrays
	{
		public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			int[] mergedArrays = mergeArrays(nums1, nums2);
            int midpointIndex = mergedArrays.Length / 2;

            if (isOddLength(mergedArrays))
			{
				return mergedArrays[midpointIndex];
			}

			int midpointIndex2 = midpointIndex - 1;

			return (mergedArrays[midpointIndex] + mergedArrays[midpointIndex2]) / (2.0);
		}

		private static bool isOddLength(int[] arr)
		{
			return arr.Length % 2 == 1;
		}

		private static int[] mergeArrays(int[] nums1, int[] nums2)
		{
			List<int> result = new List<int>();

			int index1 = 0;
			int index2 = 0;

			while(index1 < nums1.Length && index2 < nums2.Length)
			{
				if (nums1[index1] < nums2[index2])
				{
					result.Add(nums1[index1]);
					index1++;
				} else
				{
					result.Add(nums2[index2]);
					index2++;
				}
			}

			if(index1 < nums1.Length)
			{
				int toAddCount = nums1.Length - index1;
                int[] toAdd = new int[toAddCount];
				Array.Copy(nums1, index1, toAdd, 0, toAddCount);
				result.AddRange(toAdd);
			}

            if (index2 < nums2.Length)
            {
				int toAddCount = nums2.Length - index2;
                int[] toAdd = new int[toAddCount];
                Array.Copy(nums2, index2, toAdd, 0, toAddCount);
                result.AddRange(toAdd);
            }

            return result.ToArray();
		}
	}
}

