public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int res = 0, l = 0, r = people.Length - 1;

        while(l<=r){
            if(people[r] +people[l] > limit){
                r--;
            }
            else{
                r--;
                l++;
            }
                res++;
        }
        return res;
    }
}