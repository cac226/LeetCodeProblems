using System;
namespace LeetCodeProblems
{
	public class TreeNode
	{
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null)
            {
                return q == null;
            }
            if (q == null)
            {
                return false;
            }

            if (p.val != q.val)
            {
                return false;
            }

            if (!IsSameTree(p.left, q.left))
            {
                return false;
            }

            if (!IsSameTree(p.right, q.right))
            {
                return false;
            }

            return true;


        }
    }
}

