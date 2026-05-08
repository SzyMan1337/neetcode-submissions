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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null && subRoot == null) return true;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while(queue.Count >0)
        {
            var node = queue.Dequeue();

            if(node.val == subRoot.val)
            {
                if(CompareTrees(node.left, subRoot.left) && 
                    CompareTrees(node.right, subRoot.right)){
                        return true;
                    }
            }

            if(node.left !=null){
                queue.Enqueue(node.left);
            }
            if(node.right !=null){
                queue.Enqueue(node.right);
            }
        }

        return false;
    }

    public bool CompareTrees(TreeNode node1, TreeNode node2)
    {
        if(node1 == null && node2 == null) return true;
        if(node1 == null || node2 == null) return false;

        if(node1.val != node2.val) return false;

        return CompareTrees(node1.left, node2.left) && CompareTrees(node1.right, node2.right);
    }
}
