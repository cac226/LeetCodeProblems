using System;
namespace LeetCodeProblems
{
	public class Exponents
	{
        // raise x to the power of n 
        public static double MyPow(double x, int n)
        {
            if (x == 0 || x == 1)
            {
                return 1;
            }

            if(n < 0)
            {
                return myPowNegative(x, n);
            }

            return myPowPositive(x, n);
        }

        // n >= 0
        private static double myPowPositive(double x, int n)
        {
            double power = 1;

            for (int i = 0; i < n; i++)
            {
                power *= x;
            }

            return power;
        }

        // n < 0
        private static double myPowNegative(double x, int n)
        {
            double positivePower = myPowPositive(x, -n);
            return 1.0 / positivePower;
        }
    }
}

