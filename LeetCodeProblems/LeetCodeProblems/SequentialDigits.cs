using System;
namespace LeetCodeProblems
{
	public class SequentialDigits
	{
        public static IList<int> GetSequentialDigitsInRange(int low, int high)
        {
            List<int> result = new List<int>();

            int temp = getNextSequentialDigitNumber(low);

            return result;
        }

        private static int getNextSequentialDigitNumber(int num)
        {
            int numDigits = num.ToString().Length;
            int firstDigit = num / ((int)Math.Pow(10, numDigits));

            if(isValidStartingDigit(firstDigit, numDigits))
            {
                int numWithSameStartingDigit = getSequentialDigit(firstDigit, numDigits);
                if(num < numWithSameStartingDigit)
                {
                    return numWithSameStartingDigit;
                }
            }

            if(isValidStartingDigit(firstDigit + 1, numDigits))
            {
                return getSequentialDigit(firstDigit + 1, numDigits);
            }

            return -1;
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

        private static bool isValidStartingDigit(int startingDigit, int length)
        {
            return startingDigit + length <= 10;
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

