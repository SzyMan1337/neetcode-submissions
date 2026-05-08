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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        var node = root;

        while(true)
        {
            if(node.val > p.val && node.val > q.val){
                node = node.left;
            }else if(node.val < q.val && node.val < p.val){
                node = node.right;
            }else{
                break;
            }
        }
        
        return node;
    }
}
