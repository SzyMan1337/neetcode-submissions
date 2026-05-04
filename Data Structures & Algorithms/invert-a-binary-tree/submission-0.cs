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
    public TreeNode InvertTree(TreeNode root) 
    {
        var queue = new Queue<TreeNode>();

        if(root != null)
        {
            queue.Enqueue(root);
        }

        while(queue.Count > 0)
        {
            var node = queue.Dequeue();
            
            if(node.left != null)
            {
                queue.Enqueue(node.left);
            }
            if(node.right != null)
            {
                queue.Enqueue(node.right); 
            }

            var temp = node.left;
            node.left = node.right;
            node.right = temp;
        }

        return root;
    }
}
