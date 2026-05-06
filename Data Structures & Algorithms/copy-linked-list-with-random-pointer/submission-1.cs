/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary<Node, Node> oldToNew = new();
        Node dummy = new Node(0);
        Node prev = dummy;
        Node oldNode = head;
        Node newNode = dummy;

        while (oldNode != null)
        {
            newNode.next = new Node(oldNode.val);
            newNode = newNode.next;
            oldToNew.Add(oldNode, newNode);
            oldNode = oldNode.next;
        }
        oldNode = head;
        newNode = dummy.next;

        while (newNode != null) {
            newNode.random = oldNode.random == null ? null : oldToNew[oldNode.random];
            newNode = newNode.next;
            oldNode = oldNode.next;
        }

        return dummy.next;
    }
}
