public class Solution {
    public int ClimbStairs(int n) {     
        var count = 0;
        var temp = new int[n+2];
        temp[n+1]=0;
        temp[n]=1;

        for(int i =n-1; i>=0; i--){
            temp[i]= temp[i+1]+temp[i+2];
        }

        return temp[0];
    }
}
