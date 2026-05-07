public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        //long sum = piles.Sum();
        int right = piles.Max();
        int left = 1;//(int)Math.Ceiling((double)sum / h);

        while (left < right) {
            int mid = (left + right) / 2;
            long hours = 0;

            foreach (var p in piles) {
                hours += (int)Math.Ceiling((double)p / mid);
            }

            if (h >= hours) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }

        return left;
    }
}
