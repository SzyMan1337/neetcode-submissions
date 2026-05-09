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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        StringBuilder sb = new();
        var stack = new Stack<TreeNode?>();
        stack.Push(root);

        while(stack.Count >0){
            var node = stack.Pop();

            if(node == null){
                sb.Append("n,");
            }
            else{
               sb.Append($"{node.val},");
               stack.Push(node.right);
               stack.Push(node.left);
            }
        }

        return sb.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        var nodes = data.Split(',');
        int index = 0;
        return DfsDeserialize(nodes, ref index);

    }

    public TreeNode DfsDeserialize(string[] nodes, ref int index)
    {
        if(nodes.Length <= index || nodes[index] == "n"){
            index++;
            return null;
        }

        var node = new TreeNode(Int32.Parse(nodes[index]));
        index++;
        node.left = DfsDeserialize(nodes, ref index);
        node.right = DfsDeserialize(nodes, ref index);

        return node;
    }
}
