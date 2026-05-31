public class ListNode {
    public int val;
    public ListNode next, prev;

    public ListNode(int val, ListNode next = null, ListNode prev = null) {
        this.val = val;
        this.next = next;
        this.prev = prev;
    }
}

public class MyCircularQueue {
    private int space;
    private ListNode left, right;

    public MyCircularQueue(int k) {
        space = k;
        left = new ListNode(0);
        right = new ListNode(0);
        left.next = right;
        right.prev = left;
    }

    public bool EnQueue(int value) {
        if (IsFull()) {
            return false;
        }
        ListNode cur = new ListNode(value, right, right.prev);
        right.prev.next = cur;
        right.prev = cur;
        space--;
        return true;
    }

    public bool DeQueue() {
        if (IsEmpty()) {
            return false;
        }
        left.next = left.next.next;
        left.next.prev = left;
        space++;
        return true;
    }

    public int Front() {
        return IsEmpty() ? -1 : left.next.val;
    }

    public int Rear() {
        return IsEmpty() ? -1 : right.prev.val;
    }

    public bool IsEmpty() {
        return left.next == right;
    }

    public bool IsFull() {
        return space == 0;
    }
}