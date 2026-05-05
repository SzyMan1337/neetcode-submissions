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
            fast = fast?.next?.next;
            slow = slow.next;
        }

        var reorder = slow.next;
        slow.next = null;
        ListNode prev = null;
        
        while(reorder.next != null)
        {
            var temp = reorder.next;
            reorder.next = prev;
            prev = reorder;
            reorder = temp;
        }
        reorder.next = prev;

        var nod = head;
        while(reorder != null)
        {
            var temp = nod.next;
            nod.next = reorder;
            var temp2 = reorder.next;
            reorder.next = temp;
            nod = temp;
            reorder = temp2;
        }

        if(nod != null)
        {
            nod.next = null;
        }
    }
}
