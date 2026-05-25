public class Solution {
    public int OpenLock(string[] deadends, string target) {
        if (target == "0000")
            return 0;

        var visited = new HashSet<string>(deadends);
        if (visited.Contains("0000"))
            return -1;

        var q = new Queue<string>();
        q.Enqueue("0000");
        visited.Add("0000");
        int steps = 0;

        while (q.Count > 0) {
            steps++;
            int size = q.Count;
            for (int i = 0; i < size; i++) {
                string lockStr = q.Dequeue();
                for (int j = 0; j < 4; j++) {
                    foreach (int move in new int[] { 1, -1 }) {
                        int digit = (lockStr[j] - '0' + move + 10) % 10;
                        string nextLock =
                            lockStr.Substring(0, j) + digit.ToString() + lockStr.Substring(j + 1);
                        if (visited.Contains(nextLock))
                            continue;
                        if (nextLock == target)
                            return steps;
                        q.Enqueue(nextLock);
                        visited.Add(nextLock);
                    }
                }
            }
        }

        return -1;
    }
}