public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;
        int l = 0, counter = 0;
        int n = s1.Length, N = s2.Length;

        int[] s1Count = new int[26];
        int[] s2Count = new int[26];
        for (int i = 0; i < s1.Length; i++) {
            s1Count[s1[i] - 'a']++;
            s2Count[s1[i] - 'a']++;
        }

        int r = l;
        while (l + n <= N && r < N) {
            if(counter == n) return true;
            if(r<l){
                r=l;
            }

            var rightEl = s2[r] - 'a';
            if (s2Count[rightEl] == 0) {
                r = l = r + 1;
                Array.Copy(s2Count, s1Count, 26);
                counter = 0;
            } else if(s1Count[rightEl] > 0){
                s1Count[rightEl]--;
                counter++;
                r++;
            } else {
                var leftEl = s2[l] - 'a';
                counter--;
                s1Count[leftEl]++;
                l++;
            }
        }

        return counter == n;
    }
}
