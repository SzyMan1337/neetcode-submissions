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
    public List<List<int>> LevelOrder(TreeNode root) {
        var result = new List<List<int>>();
        var queue = new Queue<(TreeNode node, int level)>();

        if(root != null){
            queue.Enqueue((root, 0));
        }

        while (queue.Count > 0) {
            var (node, nodeLevel) = queue.Dequeue();

            if(result.Count < nodeLevel +1)
            {
                result.Add(new List<int>());
            }
            result[nodeLevel].Add(node.val);

            if(node.left !=null)
            {
                queue.Enqueue((node.left, nodeLevel+1));
            }
            if(node.right != null)
            {
                queue.Enqueue((node.right, nodeLevel+1));
            }
        }

        return result;
    }
}
