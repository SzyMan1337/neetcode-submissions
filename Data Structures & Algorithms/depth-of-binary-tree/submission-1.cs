/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        int maxDepth = 0;
        var stack = new Stack<(TreeNode, int)>();
        if (root != null) stack.Push((root, 1));

        while (stack.Count > 0)
        {
            var (node, depth) = stack.Pop();

            if (node.left == null && node.right == null)
            {
                maxDepth = Math.Max(maxDepth, depth);
            }

            if (node.left != null)
            {
                stack.Push((node.left, depth + 1));
            }
            if(node.right != null)
            {
                stack.Push((node.right, depth + 1));
            }
        }

        return maxDepth;
    }
}
