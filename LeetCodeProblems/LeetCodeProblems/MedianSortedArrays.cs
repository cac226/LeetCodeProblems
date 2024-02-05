using System;
namespace LeetCodeProblems
{
	public class MedianSortedArrays
	{
		public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
            int mergedArrayLength = nums1.Length + nums2.Length;
            List<int> mergedArray = new List<int>(mergedArrayLength);

            bool isMergedArrayOddLength = mergedArrayLength % 2 == 1;
            int medianIndex = mergedArrayLength / 2;

            int index1 = 0;
            int index2 = 0;

            while (index1 < nums1.Length && index2 < nums2.Length && mergedArray.Count <= medianIndex)
            {
                if (nums1[index1] < nums2[index2])
                {
                    mergedArray.Add(nums1[index1]);
                    index1++;
                }
                else
                {
                    mergedArray.Add(nums2[index2]);
                    index2++;
                }
            }

            if (medianIndex < mergedArray.Count)
            {
                return findMedian(mergedArray, medianIndex, isMergedArrayOddLength);
            }

            if (index1 < nums1.Length)
            {
                int toAddCount = nums1.Length - index1;
                int[] toAdd = new int[toAddCount];
                Array.Copy(nums1, index1, toAdd, 0, toAddCount);
                mergedArray.AddRange(toAdd);
            }

            if (index2 < nums2.Length)
            {
                int toAddCount = nums2.Length - index2;
                int[] toAdd = new int[toAddCount];
                Array.Copy(nums2, index2, toAdd, 0, toAddCount);
                mergedArray.AddRange(toAdd);
            }

            return findMedian(mergedArray, medianIndex, isMergedArrayOddLength);
        }

        private static double findMedian(List<int> mergedArray, int medianIndex, bool isMergedArrayOddLength)
        {
            if (isMergedArrayOddLength)
            {
                return mergedArray[medianIndex];
            }

            return (mergedArray[medianIndex] + mergedArray[medianIndex - 1]) / (2.0);
        }

	}
}

