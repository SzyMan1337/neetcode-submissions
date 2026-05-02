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
    public ListNode ReverseList(ListNode head) {

        if(head == null || head.next == null)
            return head;
        
        var previous = head;
        var current = head.next;
        previous.next=null;
        
        while(current.next != null)
        {
            var temp = current.next;
            current.next = previous;
            previous = current;
            current = temp;      
        }

        current.next = previous;

        return current;
    }
}
