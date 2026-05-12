public class Solution {
    public int NumIslands(char[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int counter = 0;

        for(int i=0;i<rows;i++){
            for(int j =0; j<cols; j++){
                if(grid[i][j] == '1'){
                    BFS(i,j,grid,rows,cols);
                    counter++;
                }
            }
        }
        return counter;
    }

    public void BFS(int r, int c, char[][] grid, int rows, int cols)
    {
        var queue = new Queue<(int,int)>();
        queue.Enqueue((r,c));
        grid[r][c]='#';

        while(queue.Count >0){
            var (cellRow,cellCol) = queue.Dequeue();

            int newCellRow = cellRow+1;
            if(newCellRow < rows && grid[newCellRow][cellCol] == '1'){
                grid[newCellRow][cellCol] ='#';
                queue.Enqueue((newCellRow, cellCol));
            }
            newCellRow = cellRow-1;
            if(newCellRow >=0 && grid[newCellRow][cellCol] == '1'){
                grid[newCellRow][cellCol] ='#';
                queue.Enqueue((newCellRow, cellCol));
            }

            int newCellCol = cellCol+1;
            if(newCellCol < cols && grid[cellRow][newCellCol] == '1'){
                grid[cellRow][newCellCol] ='#';
                queue.Enqueue((cellRow, newCellCol));
            }
            
            newCellCol = cellCol-1;
            if(newCellCol >=0 && grid[cellRow][newCellCol] == '1'){
                grid[cellRow][newCellCol] ='#';
                queue.Enqueue((cellRow, newCellCol));
            }
        }
    }
}
