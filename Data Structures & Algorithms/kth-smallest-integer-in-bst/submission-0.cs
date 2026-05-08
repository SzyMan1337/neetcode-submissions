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
    private int result = -1;

    public int KthSmallest(TreeNode root, int k)
    {
        var stack = new Stack<TreeNode>();
        int minCounter = 0;
        DFS(root, ref minCounter, k);

        return result;
    }

    public void DFS(TreeNode node, ref int minCounter, int k)
    {
        if (node == null || result != -1) return;

        DFS(node.left, ref minCounter, k);
        minCounter++;
        if (minCounter == k)
        {
            result = node.val;
            return;
        }
        DFS(node.right, ref minCounter, k);
    }
}
