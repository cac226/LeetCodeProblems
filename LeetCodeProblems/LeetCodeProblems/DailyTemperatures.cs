using System;
namespace LeetCodeProblems
{
	public class DailyTemperatures
	{
        /// <summary>
        /// Given an array of integers temperatures represents the daily
		/// temperatures, return an array answer such that answer[i] is the
		/// number of days you have to wait after the ith day to get a warmer
		/// temperature.
		///
		/// If there is no future day for which this is possible,
		/// keep answer[i] == 0 instead.
        /// </summary>
        public static int[] DaysToWarmerTemperature(int[] temperatures)
		{
			int[] result = new int[temperatures.Length];

			for (int i = 0; i < temperatures.Length; i++)
			{
				int j = i + 1;

				while (j < temperatures.Length && temperatures[j] <= temperatures[i])
				{
					j++;
				}

				if (j < temperatures.Length)
				{
                    result[i] = j - i;
				} else
				{
                    result[i] = 0;
				}
			}
			return result;
		}
	}
}

