public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int n = prices.Length;
        int l =0, r = 1;
        int maxProfit =0;

        while(r<n)
        {
            if(prices[l]<prices[r])
            {
                int profit = prices[r] - prices[l];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else
            {
                l=r;
            }
            r++;
        }

        return maxProfit;
    }
}
