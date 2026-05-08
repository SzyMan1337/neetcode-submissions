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
    public List<int> RightSideView(TreeNode root) {
        var result = new List<int>();
        var stack = new Stack<(TreeNode node, int level)>();
        if(root != null){
            stack.Push((root, 0));
        }

        while(stack.Count >0){
            var (node, nodeLevel) = stack.Pop();

            if(result.Count == nodeLevel){
                result.Add(node.val);
            }

            if(node.left != null){
                stack.Push((node.left, nodeLevel +1));
            }
            if(node.right != null){
                stack.Push((node.right, nodeLevel +1));
            }
        }

        return result;
    }
}
