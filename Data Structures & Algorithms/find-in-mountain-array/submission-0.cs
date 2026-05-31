/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution {
    public int FindInMountainArray(int target, MountainArray mountainArr) {
        int length = mountainArr.Length();

        // Find Peak
        int l = 1, r = length - 2, peak = 0;
        while (l <= r) {
            int m = (l + r) / 2;
            int left = mountainArr.Get(m - 1);
            int mid = mountainArr.Get(m);
            int right = mountainArr.Get(m + 1);
            if (left < mid && mid < right) {
                l = m + 1;
            } else if (left > mid && mid > right) {
                r = m - 1;
            } else {
                peak = m;
                break;
            }
        }

        // Search left portion
        l = 0;
        r = peak - 1;
        while (l <= r) {
            int m = (l + r) / 2;
            int val = mountainArr.Get(m);
            if (val < target) {
                l = m + 1;
            } else if (val > target) {
                r = m - 1;
            } else {
                return m;
            }
        }

        // Search right portion
        l = peak;
        r = length - 1;
        while (l <= r) {
            int m = (l + r) / 2;
            int val = mountainArr.Get(m);
            if (val > target) {
                l = m + 1;
            } else if (val < target) {
                r = m - 1;
            } else {
                return m;
            }
        }

        return -1;
    }
}