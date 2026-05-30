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
    public bool IsPalindrome(ListNode head) {
        ListNode fast = head.next;
        ListNode slow = head;

        while(fast?.next != null){
            fast = fast?.next?.next;
            slow = slow?.next;
        }

        var prevNode = slow;
        var node = slow.next;
        int count =1;

        while(node !=null){
            var tmp = node.next;
            node.next = prevNode;
            prevNode = node;
            node = tmp;
            count++;
        }

        var nodeBack = prevNode;
        var nodeFront = head;
        for(int i =0;i<count;i++){
            if(nodeFront.val != nodeBack.val){
                return false;
            }

            nodeFront = nodeFront.next;
            nodeBack = nodeBack.next;
        }

        return true;
    }
}