using System;
namespace LeetCodeProblems
{
	public class Exponents
	{
        // raise x to the power of n 
        public static double MyPow(double x, int n)
        {
            if(x == 0)
            {
                return n == 1 ? 0 : 1;
            }
            if (x == 1)
            {
                return 1;
            }

            double power = myPowRecursive(x, n);
            return power;
        }

        private static double myPowRecursive(double x, int n)
        {
            if(n == 0)
            {
                return 1;
            }

            if(n == 1)
            {
                return x;
            }

            if(n % 2 == 0)
            {
                int newN = n / 2;
                double power = myPowRecursive(x, newN);
                return power * power;
            }

            if(n < 0)
            {
                return myPowRecursive(x, n + 1) / x;
            }

            return x * myPowRecursive(x, n - 1);
        }

        private static double myPowPositive(double x, int n)
        {
            double power = 1;

            for (int i = 0; i < n; i++)
            {
                power *= x;
            }

            return power;
        }
    }
}

