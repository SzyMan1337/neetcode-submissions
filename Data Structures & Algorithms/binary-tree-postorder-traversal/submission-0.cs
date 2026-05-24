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
    public List<int> PostorderTraversal(TreeNode root) {
        var result = new List<int>();
        PostOrderTrav(root,result);

        return result;
    }

    public void PostOrderTrav(TreeNode node, List<int> result){
        if(node == null){
            return;
        }

        PostOrderTrav(node.left,result);
        PostOrderTrav(node.right,result);
        result.Add(node.val);
    }
}