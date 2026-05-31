public class ListNode {
    public int Key;
    public int Val;
    public int Freq;
    public ListNode Prev, Next;

    public ListNode(int key, int val) {
        Key = key;
        Val = val;
        Freq = 1;
    }
}

public class DoublyLinkedList {
    private ListNode left, right;
    private int size;

    public DoublyLinkedList() {
        left = new ListNode(0, 0);
        right = new ListNode(0, 0);
        left.Next = right;
        right.Prev = left;
        size = 0;
    }

    public int Length() {
        return size;
    }

    public void PushRight(ListNode node) {
        var prev = right.Prev;
        prev.Next = node;
        node.Prev = prev;
        node.Next = right;
        right.Prev = node;
        size++;
    }

    public void Pop(ListNode node) {
        var prev = node.Prev;
        var next = node.Next;
        prev.Next = next;
        next.Prev = prev;
        node.Prev = null;
        node.Next = null;
        size--;
    }

    public ListNode PopLeft() {
        var node = left.Next;
        Pop(node);
        return node;
    }
}

public class LFUCache {
    private int capacity;
    private int lfuCount;
    private Dictionary<int, ListNode> nodeMap;
    private Dictionary<int, DoublyLinkedList> listMap;

    public LFUCache(int capacity) {
        this.capacity = capacity;
        lfuCount = 0;
        nodeMap = new Dictionary<int, ListNode>();
        listMap = new Dictionary<int, DoublyLinkedList>();
    }

    private void Counter(ListNode node) {
        int count = node.Freq;
        listMap[count].Pop(node);

        if (count == lfuCount && listMap[count].Length() == 0) {
            lfuCount++;
        }

        node.Freq++;
        if (!listMap.ContainsKey(node.Freq)) {
            listMap[node.Freq] = new DoublyLinkedList();
        }
        listMap[node.Freq].PushRight(node);
    }

    public int Get(int key) {
        if (!nodeMap.ContainsKey(key)) {
            return -1;
        }
        var node = nodeMap[key];
        Counter(node);
        return node.Val;
    }

    public void Put(int key, int value) {
        if (capacity == 0) return;

        if (nodeMap.ContainsKey(key)) {
            var node = nodeMap[key];
            node.Val = value;
            Counter(node);
            return;
        }

        if (nodeMap.Count == capacity) {
            var toRemove = listMap[lfuCount].PopLeft();
            nodeMap.Remove(toRemove.Key);
        }

        var newNode = new ListNode(key, value);
        nodeMap[key] = newNode;
        if (!listMap.ContainsKey(1)) {
            listMap[1] = new DoublyLinkedList();
        }
        listMap[1].PushRight(newNode);
        lfuCount = 1;
    }
}