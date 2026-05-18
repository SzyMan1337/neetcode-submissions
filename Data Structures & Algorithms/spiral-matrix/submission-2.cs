public class Solution {

    private int[][] _directions = new int[][] {
        new int[] {0, 1}, new int[] {1,0},
        new int[] {0, -1}, new int[] {-1,0}
    };


    public List<int> SpiralOrder(int[][] matrix) {
        var result = new List<int>();
        result.Add(matrix[0][0]);
        int n = matrix.Length;
        int m = matrix[0].Length;

        int minAllowedRow = 0;
        int maxAllowedRow = n-1;
        int maxAllowedColumn = m-1;
        int minAllowedColumn = 0;

        int row= 0, col =0;
        int elements = n*m-1;
        var currentDirId = 0;
        
        while(elements!=0){
            int rowDir = _directions[currentDirId][0];
            int colDir = _directions[currentDirId][1];

            while(row +rowDir >= minAllowedRow && row +rowDir <= maxAllowedRow &&
                col +colDir >= minAllowedColumn && col +colDir <= maxAllowedColumn){
                    row +=rowDir;
                    col +=colDir;

                    result.Add(matrix[row][col]);
                    elements--;
                }

            currentDirId = (currentDirId+1)%4;
            if(_directions[currentDirId][0] == 1){
                minAllowedRow +=1;
            }
            else if(_directions[currentDirId][0] == -1){
                maxAllowedRow -=1;
            }
            else if(_directions[currentDirId][1] == 1){
                minAllowedColumn +=1;
            }
            else if(_directions[currentDirId][1] == -1){
                maxAllowedColumn -=1;
            }
        }

        return result;
    }
}
