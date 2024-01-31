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

                // If it's the same temperature for several days in a row, then
                // we can note how many days in a row the temperature stays the same
				// to make calculation faster.
				// This particular method only works with adjasent matching temperatures
				// (i.e. not 90, 90, 89, 90), so we need a boolean marker to determine if
				// we're still in a valid state to make the necessary calculations
                int daysWithSameTemp = 1;
				bool sameTemperatureAdjasentMarker = true; 

				while (j < temperatures.Length && temperatures[j] <= temperatures[i])
				{
					if (sameTemperatureAdjasentMarker && temperatures[i] == temperatures[j])
					{
						daysWithSameTemp++;
					} else
					{
						sameTemperatureAdjasentMarker = false;
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

