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
    public bool IsValidBST(TreeNode root) {
        return BFS(root, 1001, -1001);
    }

    public bool BFS(TreeNode node, int prevMax, int prevMin) {
        if (node == null)
            return true;

        if (node.val >= prevMax || node.val <= prevMin)
            return false;

        if(BFS(node.left, Math.Min(prevMax, node.val), prevMin) && 
             BFS(node.right, prevMax, Math.Max(node.val, prevMin))){
                return true;
             }

        return false;
    }
}
