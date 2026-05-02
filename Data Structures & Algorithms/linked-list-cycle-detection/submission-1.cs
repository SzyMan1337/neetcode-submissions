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
    public bool HasCycle(ListNode head) {
        var slowPointer = head;
        var fastPointer = head?.next?.next;

        while(fastPointer != null && slowPointer != fastPointer){
            fastPointer = fastPointer?.next?.next;
            slowPointer = slowPointer?.next;
        }

        return slowPointer == fastPointer && slowPointer !=null;
    }
}
