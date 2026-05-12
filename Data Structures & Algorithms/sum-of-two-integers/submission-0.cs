public class Solution {
    public int GetSum(int a, int b) {
        while(b!=0){
            var tmp = (a&b) << 1;
            a ^=b;
            b= tmp;
        }

        return a;
    }
}
