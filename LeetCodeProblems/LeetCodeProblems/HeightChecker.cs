using System;
namespace LeetCodeProblems
{
	public class HeightChecker
	{
        /*
		 A school is trying to take an annual photo of all the students. The
		students are asked to stand in a single file line in non-decreasing
		order by height. Let this ordering be represented by the integer array
		expected where expected[i] is the expected height of the ith student
		in line.

		You are given an integer array heights representing the current order
		that the students are standing in. Each heights[i] is the height of the
		ith student in line (0-indexed).

		Return the number of indices where heights[i] != expected[i].

		
		1 <= heights.length <= 100
		1 <= heights[i] <= 100

		 */
        public static int CheckHeight(int[] heights)
		{
			int[] heightOccurances = new int[101];

			for(int i = 0; i < heights.Length; i++)
			{
				int val = heights[i];
				heightOccurances[val]++;
			}

            int nonmatching = 0;
			int index = 0;

            for (int heightVal = 1; heightVal < heightOccurances.Length; heightVal++)
			{
				while (heightOccurances[heightVal] > 0)
				{
					if (heights[index] != heightVal)
					{
						nonmatching++;
					}
					index++;
					heightOccurances[heightVal]--;
				}
			}

			return nonmatching;
		}
	}
}

