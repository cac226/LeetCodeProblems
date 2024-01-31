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
			int i = 0;
			while(i < temperatures.Length)
			{
				int j = i + 1;
				int daysWithSameTemp = 1;
				bool sameTempInARow = true;

				while (j < temperatures.Length && temperatures[j] <= temperatures[i])
				{
					if (sameTempInARow && temperatures[i] == temperatures[j])
					{
						daysWithSameTemp++;
					} else
					{
						sameTempInARow = false;
                    }
					j++;
				}

				if (j < temperatures.Length)
				{
					int startingDay = i;
					while(i < startingDay + daysWithSameTemp)
					{
                        result[i] = j - i;
						i++;
                    }
				} else
				{
                    result[i] = 0;
                    i++;
                }
			}
			return result;
		}
	}
}

