public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        int left = 0;
        int right = n - 1;

        while (left < right) {
            var limit = right - left;

            for (int i = 0; i < limit; i++) {
                (int top, int bottom) = (left, right);

                // save the top left position
                var topLeft = matrix[top][left + i];

                matrix[top][left + i] = matrix[bottom - i][left];
                matrix[bottom - i][left] = matrix[bottom][right - i];
                matrix[bottom][right - i] = matrix[top + i][right];
                matrix[top + i][right] = topLeft;
            }
            left++;
            right--;
        }

        return;
    }
}
