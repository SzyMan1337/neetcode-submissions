/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        var node = head;
        var nextNode = head.next;

        while(nextNode != null){
            int newNodeVal = GCD(node.val, nextNode.val);
            node.next = new ListNode(newNodeVal, nextNode);

            node = nextNode;
            nextNode = nextNode.next;
        }

        return head;
    }

    private int GCD(int a, int b){
        while(b!=0){
            int tmp = b;
            b= a%b;
            a=tmp;
        }

        return a;
    }
}