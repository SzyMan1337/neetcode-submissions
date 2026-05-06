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

public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        if(l1 == null) return l2;
        if(l2 == null) return l1;

        ListNode dummy = new ListNode(0);
        ListNode node = dummy;
        int extra = 0;

        while(l1 != null && l2 != null)
        {
            int sum = l1.val+l2.val+extra;
            extra = sum / 10;
            node.next = new ListNode(sum%10);
            node = node.next;

            l1 = l1.next;
            l2 = l2.next;
        }
        
        ListNode finishSum = l1 != null? l1:l2;
        while(finishSum != null)
        {
            int sum = finishSum.val+extra;
            extra = sum / 10;
            node.next = new ListNode(sum%10);
            node = node.next;
            finishSum = finishSum.next;
        }
        if(extra != 0)
        {
            node.next = new ListNode(extra);
        }

        return dummy.next;
    }
}
