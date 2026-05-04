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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        var stackP = new Stack<TreeNode>();
        var stackQ = new Stack<TreeNode>();

        if(q == null && q != p) return false;
        if(q == null) return true;

        stackP.Push(p);
        stackQ.Push(q);

        while(stackP.Count > 0)
        {
            var qNode = stackQ.Pop();
            var pNode = stackP.Pop();

            if(qNode?.val != pNode?.val) return false;
            
            if(qNode !=null)
            {
                stackP.Push(pNode.left);
                stackP.Push(pNode.right);
                stackQ.Push(qNode.left);
                stackQ.Push(qNode.right);
            }
        }

        return true;
    }
}
