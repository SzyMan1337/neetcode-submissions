/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null){
            return null;
        }

        Dictionary<Node, Node> oldToNew = new();

        var newNode = new Node(node.val);
        oldToNew.Add(node, newNode);
        var queue = new Queue<Node>();

        foreach(var neigh in node.neighbors){
            var newNeigh = new Node(neigh.val);
            oldToNew.Add(neigh, newNeigh);
            newNode.neighbors.Add(newNeigh);
            queue.Enqueue(neigh);
        }

        while(queue.Count >0){
            var oldNod = queue.Dequeue();
            var newNod = oldToNew[oldNod];

            foreach(var oldNeigh in oldNod.neighbors){
                var newNeigh = GetCopyNode(oldToNew, oldNeigh);
                newNod.neighbors.Add(newNeigh);

                if(!oldToNew.ContainsKey(oldNeigh)){
                    oldToNew.Add(oldNeigh, newNeigh);
                    queue.Enqueue(oldNeigh);
                }
            }
        }

        return newNode;
    }

    private Node GetCopyNode(Dictionary<Node, Node> oldToNew, Node node){
        if(oldToNew.ContainsKey(node)){
            return oldToNew[node];
        }

        return new Node(node.val);
    }
}
