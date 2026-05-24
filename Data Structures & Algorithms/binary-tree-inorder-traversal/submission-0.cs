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
    public List<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();

        RunInorderTraversal(root,result);

        return result;
    }

    public void RunInorderTraversal(TreeNode node, List<int> result){
        if(node == null){
            return;
        }

        RunInorderTraversal(node.left, result);
        result.Add(node.val);
        RunInorderTraversal(node.right, result);
    }
}