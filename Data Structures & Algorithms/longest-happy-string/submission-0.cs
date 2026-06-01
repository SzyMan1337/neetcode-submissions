public class Solution {
    public string LongestDiverseString(int a, int b, int c) {
        var heap = new PriorityQueue<(char, int), int>();
        if (a > 0)
            heap.Enqueue(('a', a), -a);

        if (b > 0)
            heap.Enqueue(('b', b), -b);

        if (c > 0)
            heap.Enqueue(('c', c), -c);

        var sb = new StringBuilder();
        var blockedChar = '-';
        int blockedCount = 0;
        char prevChar = '-';

        while (heap.Count > 0) {
            var (ca, n) = heap.Dequeue();

            sb.Append(ca);
            n--;

            if (blockedCount > 0) {
                heap.Enqueue((blockedChar, blockedCount), -blockedCount);
                blockedCount = 0;
            }

            if (n > 0) {
                if (prevChar != ca) {
                    heap.Enqueue((ca, n), -n);
                } else {
                    blockedChar = ca;
                    blockedCount = n;
                }
            }

            prevChar = ca;
        }

        return sb.ToString();
    }
}