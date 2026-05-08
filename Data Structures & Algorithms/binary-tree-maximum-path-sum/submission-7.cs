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
    public int MaxPathSum(TreeNode root)
    {
        int maxSum = root.val;
        DFS(root, ref maxSum);
        return maxSum;
    }

    public int DFS(TreeNode node, ref int maxSum)
    {
        if (node == null)
            return 0;

        int leftGain = DFS(node.left, ref maxSum);
        int rightGain = DFS(node.right, ref maxSum);

        maxSum = Math.Max(maxSum, node.val + leftGain + rightGain);

        return Math.Max(Math.Max(leftGain, rightGain) + node.val, 0);
    }
}
