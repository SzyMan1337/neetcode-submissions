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
    public List<List<int>> ZigzagLevelOrder(TreeNode root) {
        var queue = new Queue<TreeNode>();
        var result = new List<List<int>>();
        if(root == null){
            return result;
        }
        bool fromLeft = true;

        queue.Enqueue(root);
        while(queue.Count >0){
            var newQueue = new Queue<TreeNode>();
            var curList = new List<int>();

            while(queue.Count >0){
                var node = queue.Dequeue();
                curList.Add(node.val);

                if(node.left != null){
                    newQueue.Enqueue(node.left);
                }
                if(node.right != null){
                    newQueue.Enqueue(node.right);
                }
            }

            queue = newQueue;

            if(!fromLeft){
                curList = curList.AsEnumerable().Reverse().ToList();
            }
            result.Add(curList);
            fromLeft = !fromLeft;
        }
        
        return result;
    }
}