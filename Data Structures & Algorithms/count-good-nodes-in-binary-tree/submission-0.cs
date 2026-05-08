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

    public int GoodNodes(TreeNode root) {
        int result = 0;
        DFS(root, -101, ref result);

        return result;
    }

    public void DFS(TreeNode node, int maxBefore, ref int result)
    {
        if(node == null){
            return;
        }

        if(maxBefore <= node.val){
            maxBefore = node.val;
            result++;
        }

        DFS(node.left, maxBefore, ref result);
        DFS(node.right, maxBefore, ref result);
    }
}
