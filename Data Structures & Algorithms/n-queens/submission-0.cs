public class Solution {
    public List<List<string>> SolveNQueens(int n) {
        var result = new List<List<string>>();
        var rowsBlocked = new HashSet<int>();
        var diagonalBlocked = new HashSet<int>();
        var currentSolution = new List<int>();

        Backtrack(result, rowsBlocked, diagonalBlocked, currentSolution, n, 0);

        return result;
    }


    public void Backtrack(List<List<string>> result, HashSet<int> rowsBlocked,
        HashSet<int> diagonalBlocked, List<int> currentSolution, int n, int i)
        {
            if(i==n){
                var res = new List<string>();
                foreach(var s in currentSolution){
                    var sb = new StringBuilder();
                    for(int p = 0;p<n;p++){
                        if(p != s){
                            sb.Append('.');
                        }else{
                            sb.Append('Q');
                        }
                    }
                    res.Add(sb.ToString());
                }

                result.Add(res);
                return;
            }

            for(int j =0; j<n; j++){
                int diagN = j+currentSolution.Count;
                int diagN2 = currentSolution.Count - j -n;
                if(!rowsBlocked.Contains(j) && !diagonalBlocked.Contains(diagN) && 
                    !diagonalBlocked.Contains(diagN2)){          
                    diagonalBlocked.Add(diagN);
                    diagonalBlocked.Add(diagN2);  
                    currentSolution.Add(j);
                    rowsBlocked.Add(j);
                    Backtrack(result, rowsBlocked, diagonalBlocked, currentSolution, n, i+1);
                    rowsBlocked.Remove(j);
                    currentSolution.RemoveAt(currentSolution.Count-1);
                    diagonalBlocked.Remove(diagN);
                    diagonalBlocked.Remove(diagN2);  
                }
            }
        }
}
