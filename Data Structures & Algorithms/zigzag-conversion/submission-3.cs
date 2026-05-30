public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows <= 1 || s.Length <= numRows)
            return s;

        int n = s.Length;
        int lastRow = numRows - 1;
        int cycle = lastRow * 2;
        int newPos = 0;
        char[] result = new char[n];

        // First row
        for (int i = 0; i < n; i += cycle) {
            result[newPos++] = s[i];
        }

        // Middle rows
        for (int row = 1; row < lastRow; row++) {
            for (int el = 0; el - row < n; el += cycle) {
                int left = el - row;
                int right = el + row;

                if (left >= 0) {
                    result[newPos++] = s[left];
                }

                if (right < n) {
                    result[newPos++] = s[right];
                }
            }
        }

        // Last row
        for (int i = lastRow; i < n; i += cycle) {
            result[newPos++] = s[i];
        }

        return new string(result);
    }
}