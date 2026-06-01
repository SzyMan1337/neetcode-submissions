public class Solution {
    public bool CanReach(string s, int minJump, int maxJump) {
        int n = s.Length;

        Queue<int> q = new Queue<int>();
        q.Enqueue(0);

        int farthest = 0;

        while (q.Count > 0) {
            int pos = q.Dequeue();

            if (pos == n - 1) {
                return true;
            }

            int start = Math.Max(farthest + 1, pos + minJump);
            int end = Math.Min(pos + maxJump, n - 1);

            for (int i = start; i <= end; i++) {
                if (s[i] == '0') {
                    q.Enqueue(i);
                }
            }

            farthest = Math.Max(farthest, end);
        }

        return false;
    }
}