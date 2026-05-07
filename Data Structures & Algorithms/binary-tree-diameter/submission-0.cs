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
    public int DiameterOfBinaryTree(TreeNode root) {
        int res = 0;
        DFS(root, ref res);
        return res;
    }

    public int DFS(TreeNode node, ref int res)
    {
        if(node == null) return -1;

        int leftHeight = DFS(node.left, ref res) +1;
        int rightHeight = DFS(node.right, ref res)+1;

        res = Math.Max(leftHeight+rightHeight, res);

        return Math.Max(leftHeight, rightHeight);
    }
}
