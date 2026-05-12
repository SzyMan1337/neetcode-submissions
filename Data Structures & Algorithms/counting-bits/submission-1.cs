public class Solution {
    public int[] CountBits(int n) {
        var result = new int[n+1];
        int nextBig = 1;
        int j=1;

        for(int i =1; i<=n; i++)
        {
            if(i==nextBig){
                nextBig*=2;
                result[i]=1;
                j=1;
                continue;
            }

            result[i] = 1 + result[j];
            j++;
        }

        return result;
    }
}
