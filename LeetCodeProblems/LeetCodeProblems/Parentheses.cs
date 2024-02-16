using System;
namespace LeetCodeProblems
{
	public class Parentheses
	{
        /// <summary>
        /// Given n pairs of parentheses, write a function to generate all
        /// combinations of well-formed parentheses.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<string> GenerateParenthesis(int n)
        {
            IList<string> parenthesis = addChar("", n, 0);
            return parenthesis;
        }

        private static IList<string> addChar(string str, int parenthesisToAdd, int unclosedParenthesis)
        {
            if(parenthesisToAdd == 0 && unclosedParenthesis == 0)
            {
                return new List<string>() { str };
            }

            List<string> result = new List<string>();
            if (0 < parenthesisToAdd)
            {
                // can open
                result.AddRange(addChar(str + "(", parenthesisToAdd - 1, unclosedParenthesis + 1));
            }
            if (0 < unclosedParenthesis)
            {
                // can close
                result.AddRange(addChar(str + ")", parenthesisToAdd, unclosedParenthesis - 1));
            }
            return result;
        }
    }
}

