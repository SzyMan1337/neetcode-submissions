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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if (root == null)
            return null;

        TreeNode parent = null;
        TreeNode cur = root;

        // Find the node to delete
        while (cur != null && cur.val != key) {
            parent = cur;
            if (key > cur.val) {
                cur = cur.right;
            } else {
                cur = cur.left;
            }
        }

        if (cur == null)
            return root;

        if (cur.left == null || cur.right == null) {
            TreeNode child = cur.left != null ? cur.left : cur.right;

            if (parent == null) {
                return child;
            }

            if (parent.left == cur) {
                parent.left = child;
            } else {
                parent.right = child;
            }
        } else {
            var replaceNode = FindAndDeleteMinNodeOnRight(cur);

            replaceNode.left = cur.left;
            if (parent == null) {
                return replaceNode;
            }

            if (parent.left == cur) {
                parent.left = replaceNode;
            } else {
                parent.right = replaceNode;
            }
        }

        return root;
    }

    public TreeNode FindAndDeleteMinNodeOnRight(TreeNode delNode) {
        TreeNode parent = null;
        TreeNode curIt = delNode.right;

        while (curIt.left != null) {
            parent = curIt;
            curIt = curIt.left;
        }

        if (parent != null) {
            parent.left = curIt.right;
            curIt.right = delNode.right;
        }

        return curIt;
    }
}