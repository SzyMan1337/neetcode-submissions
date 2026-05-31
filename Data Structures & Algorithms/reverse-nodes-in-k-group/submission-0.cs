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
    public ListNode ReverseKGroup(ListNode head, int k) {
        var dummy = new ListNode(0,head);

        ListNode sectionHead = dummy;
        ListNode sectionEnd = head;
        ListNode node = head;
        ListNode prevParent = null;
        int count = 0;
        
        while (HasKNodes(node, k)) {
            while(count < k && node != null){
                var tmp = node.next;
                node.next = prevParent;
                prevParent = node;
                node = tmp;

                count++;
            }

            sectionHead.next = prevParent;
            sectionEnd.next = node;

            sectionHead = sectionEnd;
            sectionEnd = node;
            prevParent = null;
            count = 0;
        }

        return dummy.next;         
    }

    private bool HasKNodes(ListNode node, int k) {
        while (node != null && k > 0) {
            node = node.next;
            k--;

        }
        return k == 0;
    }
}