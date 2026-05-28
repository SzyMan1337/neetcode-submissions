public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int l = weights.Max();
        int r = weights.Sum(); // if days = 1 we need to ship everything at once
        int res = r;

        while(l<r){
            int m = (l+r)/2;

            bool possibleToShip = CheckIfCanBeShipped(weights,days,m);
            if(possibleToShip){
                r = m;
                res =r;
            }else{
                l=m+1;
            }
        }
        return res;
    }

    public bool CheckIfCanBeShipped(int[] weights, int days, int m){
        int curSum = 0;

        foreach(var w in weights){
            if(curSum + w > m){
                curSum = 0;
                days--;
            }

            curSum += w;
        }

        return days >0;
    }
}