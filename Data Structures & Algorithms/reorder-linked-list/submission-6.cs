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

        while(fast?.next?.next !=null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode curr = slow.next;
        slow.next = null;
        ListNode prev = null;

        while(curr != null){
            ListNode tmp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tmp;
        }

        ListNode reverseCurr = prev;
        ListNode normalCurr = head;

        while(reverseCurr != null){
            var tmp2 = reverseCurr.next;
            var tmp1 = normalCurr.next;

            normalCurr.next = reverseCurr;
            reverseCurr.next = tmp1;

            normalCurr = tmp1;
            reverseCurr = tmp2;
        }


        // if(head == null || head.next == null) return;

        // var slow = head; 
        // var fast = head;

        // while(fast?.next?.next != null)
        // {
        //     fast = fast.next.next;
        //     slow = slow.next;
        // }

        // var reorder = slow.next;
        // ListNode prev = slow.next = null;
        // while(reorder != null)
        // {
        //     var temp = reorder.next;
        //     reorder.next = prev;
        //     prev = reorder;
        //     reorder = temp;
        // }

        // var nod = head;
        // while(prev != null)
        // {
        //     var temp = nod.next;
        //     nod.next = prev;
        //     var temp2 = prev.next;
        //     prev.next = temp;
        //     nod = temp;
        //     prev = temp2;
        // }
    }
}
