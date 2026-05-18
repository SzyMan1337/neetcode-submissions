public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rowZero = -1;

        for (int i = 0; i < matrix.Length; i++) {
            for (int j = 0; j < matrix[0].Length; j++) {
                if (matrix[i][j] == 0) {
                    if (i == 0) {
                        rowZero = 0;
                    } else {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }
        }

        for (int i = 1; i < matrix.Length; i++) {
            if (matrix[i][0] == 0) {
                for (int j = 1; j < matrix[0].Length; j++) {
                    matrix[i][j] = 0;
                }
            }
        }

        for (int j = 1; j < matrix[0].Length; j++) {
            if (matrix[0][j] == 0) {
                for (int i = 1; i < matrix.Length; i++) {
                    matrix[i][j] = 0;
                }
            }
        }

        if (matrix[0][0] == 0) {
            for (int i = 1; i < matrix.Length; i++) {
                matrix[i][0] = 0;
            }
        }

        if (rowZero == 0) {
            for (int j = 0; j < matrix[0].Length; j++) {
                matrix[0][j] = 0;
            }
        }
    }
}
