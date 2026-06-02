public class Solution {
    public char[][] RotateTheBox(char[][] boxGrid) {
        int ROWS = boxGrid.Length, COLS = boxGrid[0].Length;
        for (int r = 0; r < ROWS; r++) {
            int i = COLS - 1;
            for (int c = COLS - 1; c >= 0; c--) {
                if (boxGrid[r][c] == '#') {
                    boxGrid[r][c] = '.';
                    boxGrid[r][i] = '#';
                    i--;
                } else if (boxGrid[r][c] == '*') {
                    i = c - 1;
                }
            }
        }
        char[][] res = new char[COLS][];
        for (int c = 0; c < COLS; c++) {
            res[c] = new char[ROWS];
            for (int r = ROWS - 1; r >= 0; r--) {
                res[c][ROWS - 1 - r] = boxGrid[r][c];
            }
        }
        return res;
    }
}