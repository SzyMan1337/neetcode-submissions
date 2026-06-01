public class Solution {
    public int TotalNQueens(int n) {
        int result = 0;
        var rowsBlocked = new HashSet<int>();
        var diagonalBlocked = new HashSet<int>();
        var currentSolution = new List<int>();

        Backtrack(ref result, rowsBlocked, diagonalBlocked, currentSolution, n, 0);

        return result;
    }


    public void Backtrack(ref int result, HashSet<int> rowsBlocked,
                          HashSet<int> diagonalBlocked, List<int> currentSolution, int n, int i) {
        if (i == n) {
            result++;
            return;
        }

        for (int j = 0; j < n; j++) {
            int diagN = j + currentSolution.Count;
            int diagN2 = currentSolution.Count - j - n;
            if (!rowsBlocked.Contains(j) && !diagonalBlocked.Contains(diagN) &&
                !diagonalBlocked.Contains(diagN2)) {
                diagonalBlocked.Add(diagN);
                diagonalBlocked.Add(diagN2);
                currentSolution.Add(j);
                rowsBlocked.Add(j);
                Backtrack(ref result, rowsBlocked, diagonalBlocked, currentSolution, n, i + 1);
                rowsBlocked.Remove(j);
                currentSolution.RemoveAt(currentSolution.Count - 1);
                diagonalBlocked.Remove(diagN);
                diagonalBlocked.Remove(diagN2);
            }
        }
    }
}