public class Solution {
    private int ROWS, COLS;

    public bool Exist(char[][] board, string word) {
        ROWS = board.Length;
        COLS = board[0].Length;

        for (int r = 0; r < ROWS; r++) {
            for (int c = 0; c < COLS; c++) {
                if (Backtrack(board, word, r, c, 0)) {
                    return true;
                }
            }
        }
        return false;
    }

    public bool Backtrack(char[][] board, string word, int r, int c, int i) {
        if (i == word.Length) {
            return true;
        }

        if (r < 0 || r >= ROWS || c < 0 || c >= COLS || board[r][c] != word[i]) {
            return false;
        }

        board[r][c] = '#';
        bool res = Backtrack(board, word, r + 1, c, i + 1) ||
                   Backtrack(board, word, r - 1, c, i + 1) ||
                   Backtrack(board, word, r, c + 1, i + 1) ||
                   Backtrack(board, word, r, c - 1, i + 1);
        board[r][c] = word[i];

        return res;
    }
}
