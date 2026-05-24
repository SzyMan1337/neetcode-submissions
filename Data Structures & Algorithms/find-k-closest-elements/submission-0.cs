public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        int l = 0, r = arr.Length - k;
        while (l < r) {
            int m = (l + r) / 2;
            if (Math.Abs(x - arr[m]) > Math.Abs(arr[m + k] - x)) {
                l = m + 1;
            } else {
                r = m;
            }
        }
        var result = new List<int>();
        for (int i = l; i < l + k; i++) {
            result.Add(arr[i]);
        }
        return result;
    }
}