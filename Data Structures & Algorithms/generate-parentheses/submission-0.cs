public class Solution {
    public List<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        var current = new char[n * 2];

        Backtrack(current, n, n, result, 0);

        return result;
    }

    public void Backtrack(char[] current, int toOpenRemaning, int toCloseRemaning,
        List<string> result, int index) {
        if (index == current.Length) {
            result.Add(new string(current));
            return;
        }

        if (toOpenRemaning > 0) {
            current[index] = '(';
            Backtrack(current, toOpenRemaning - 1, toCloseRemaning, result, index + 1);
        }

        if (toCloseRemaning > toOpenRemaning) {
            current[index] = ')';
            Backtrack(current, toOpenRemaning, toCloseRemaning - 1, result, index + 1);
        }
    }
}
