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

public class Solution {
    public int MaxPathSum(TreeNode root) {
        int maxSum = -1001;
        DFS(root, ref maxSum);
        return maxSum;
    }

    public int DFS(TreeNode node, ref int maxSum) {
        if (node == null)
            return -1001;

        int currentSum = node.val > 0 ? node.val : 0;
        int leftSum = DFS(node.left, ref maxSum);
        int rightSum = DFS(node.right, ref maxSum);

        maxSum = new int[] { maxSum, node.val, node.val + leftSum + rightSum, leftSum + currentSum,
                             rightSum + currentSum }
                     .Max();

        return Math.Max(Math.Max(leftSum + node.val, rightSum + node.val), node.val);
    }
}
