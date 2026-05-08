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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if(preorder.Length == 0) {
            return null;
        }

        var head = new TreeNode(preorder[0]);

        var mid = Array.IndexOf(inorder, preorder[0]);

        head.left = BuildTree(preorder[1..(mid+1)], inorder[..mid]);
        head.right = BuildTree(preorder[(mid+1)..], inorder[(mid+1)..]);

        return head;
    }

    
}
