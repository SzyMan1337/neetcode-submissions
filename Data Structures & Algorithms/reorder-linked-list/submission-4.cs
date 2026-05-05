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
    public void ReorderList(ListNode head) 
    {
        if(head == null || head.next == null) return;

        var slow = head; 
        var fast = head;

        while(fast?.next?.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        var reorder = slow.next;
        ListNode prev = slow.next = null;
        while(reorder != null)
        {
            var temp = reorder.next;
            reorder.next = prev;
            prev = reorder;
            reorder = temp;
        }

        var nod = head;
        while(prev != null)
        {
            var temp = nod.next;
            nod.next = prev;
            var temp2 = prev.next;
            prev.next = temp;
            nod = temp;
            prev = temp2;
        }
    }
}
