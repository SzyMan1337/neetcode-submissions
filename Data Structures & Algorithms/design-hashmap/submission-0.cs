public class ListNode {
    public int key;
    public int val;
    public ListNode next;

    public ListNode(int key = -1, int val = -1, ListNode next = null) {
        this.key = key;
        this.val = val;
        this.next = next;
    }
}

public class MyHashMap {
    private ListNode[] map;

    public MyHashMap() {
        map = new ListNode[1000];
        for (int i = 0; i < map.Length; i++) {
            map[i] = new ListNode();
        }
    }

    private int Hash(int key) {
        return key % map.Length;
    }

    public void Put(int key, int value) {
        ListNode cur = map[Hash(key)];
        while (cur.next != null) {
            if (cur.next.key == key) {
                cur.next.val = value;
                return;
            }
            cur = cur.next;
        }
        cur.next = new ListNode(key, value);
    }

    public int Get(int key) {
        ListNode cur = map[Hash(key)].next;
        while (cur != null) {
            if (cur.key == key) {
                return cur.val;
            }
            cur = cur.next;
        }
        return -1;
    }

    public void Remove(int key) {
        ListNode cur = map[Hash(key)];
        while (cur.next != null) {
            if (cur.next.key == key) {
                cur.next = cur.next.next;
                return;
            }
            cur = cur.next;
        }
    }
}