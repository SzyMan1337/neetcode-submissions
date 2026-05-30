public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || s.Length <= 1)
            return s;

        char[] result = new char[s.Length];
        int n = s.Length;
        int newPos = 0, i = 0;

        numRows--;

        while (i < n) {
            result[newPos] = s[i];
            i += numRows * 2;
            newPos++;
        }

        for (int j = 1; j < numRows; j++) {
            int el = 0;

            while (el - j < n) {
                if (el - j >= 0) {
                    result[newPos] = s[el - j];
                    newPos++;
                }

                if (el + j < n) {
                    result[newPos] = s[el + j];
                    newPos++;
                }

                el += numRows * 2;
            }
        }

        i = numRows;
        while (i < n) {
            result[newPos] = s[i];
            i += numRows * 2;
            newPos++;
        }

        return new string(result);
    }
}