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
    public bool IsBalanced(TreeNode root) 
    {
        bool res = true;

        DFS(root, ref res);
        return res;
    }

    public int DFS(TreeNode node, ref bool res)
    {
        if(res == false || node == null) return 0;

        int left = DFS(node.left, ref res);
        int right = DFS(node.right, ref res);

        if(Math.Abs(left-right) > 1){
            res = false;
        }

        return Math.Max(left, right)+1;
    }
}
