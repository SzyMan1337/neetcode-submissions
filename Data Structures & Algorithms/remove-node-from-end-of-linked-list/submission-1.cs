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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode nodeN = head;
        ListNode node = head, prev = null;

        for (int i = 1; i < n; i++)
        {
            nodeN = nodeN.next;
        }

        while (nodeN.next != null)
        {
            nodeN = nodeN.next;
            prev = node;
            node = node.next;
        }

        if(prev == null)
        {
            head = node.next;
        }
        else
        {
            prev.next = node.next;
        }

        return head;
    }
}
