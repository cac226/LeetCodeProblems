using System;
namespace LeetCodeProblems
{
	public class RemovingElements
	{
        /// <summary>
        /// Given an array of integers arr and an integer k. Find the least
        /// number of unique integers after removing exactly k elements.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            List<int> distinctIntOccurances = arr.GroupBy(x => x)
                                                .Select(x => x.Count())
                                                .OrderDescending()
                                                .ToList();

            int leftToRemove = k;

            while (distinctIntOccurances.Any() &&
                distinctIntOccurances.Last() <= leftToRemove)
            {
                leftToRemove -= distinctIntOccurances.Last();
                distinctIntOccurances.RemoveAt(distinctIntOccurances.Count - 1);
            }

            return distinctIntOccurances.Count;
        }
    }
}

