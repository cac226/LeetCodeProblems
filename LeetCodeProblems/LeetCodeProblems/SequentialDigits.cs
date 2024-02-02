using System;
namespace LeetCodeProblems
{
	public class SequentialDigits
	{
        public static IList<int> GetSequentialDigitsInRange(int low, int high)
        {
            List<int> allSequentialDigits = new List<int>();

            int lowDigitCount = low.ToString().Length;
            int highDigitCount = high.ToString().Length;

            for(int i = lowDigitCount; i <= highDigitCount; i++)
            {
                allSequentialDigits.AddRange(getAllSeuqntialDigitsOfLength(i));
            }

            // If I wanted to make this more efficient (but spend more time writing it)
            // I wouldn't use LINQ 
            List<int> result = allSequentialDigits.Where(x => low <= x && x <= high)
                                                  .ToList();

            return result;
        }

        private static List<int> getAllSeuqntialDigitsOfLength(int length)
        {
            List<int> result = new List<int>();
            
            for(int i = 1; i <= 10 - length; i++)
            {
                result.Add(getSequentialDigit(i, length));
            }

            return result;
        }

        private static int getSequentialDigit(int startingDigit, int length)
        {
            string number = "";

            for (int digit = 0; digit < length; digit++)
            {
                number += (startingDigit + digit);
            }

            return Int32.Parse(number);
        }
    }
}

