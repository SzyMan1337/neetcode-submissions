public class Solution {
    public bool CheckValidString(string s) {
        int maxLeft = 0;
        int minLeft = 0;

        for (int i = 0; i < s.Length; i++) {

            if(s[i] =='('){
                maxLeft++;
                minLeft++;
            }
            else if(s[i] == ')'){
                maxLeft--;
                minLeft--;
            }
            else {
                minLeft--;
                maxLeft++;
            }

            if(maxLeft <0){
                return false;
            }
            if(minLeft <0){
                minLeft =0;
            }
        }

        return minLeft ==0;
    }
}