public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        int n =matrix.Length;
        int m = matrix[0].Length;
        int l =0, r = n*m-1;

        while(l<=r)
        { 
            int medIndex = (l +r)/2;
            var med = matrix[medIndex/m][medIndex%m];

            if(med > target)
            {
                r = medIndex -1;
            }
            else if( med < target)
            {
                l = medIndex +1;
            }
            else 
            {
                return true;
            }
        }

        return false;
    }
}
