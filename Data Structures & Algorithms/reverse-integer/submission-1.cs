public class Solution {
    public int Reverse(int x) {
        int maxValue = int.MaxValue/10;
        int maxValueLastDigit = int.MaxValue%10;
        int minValue = int.MinValue/10;
        int minValueLastDigit = int.MinValue%10;

        int result = 0;
        while(x!=0){
            int digit = x%10;
            x/=10;

            if(result > maxValue || (result == maxValue && x >maxValueLastDigit)){
                return 0;
            }

            if(result < minValue || (result == minValue && x < minValueLastDigit)){
                return 0;
            }

            result = result*10+digit;
        }

        return result;
    }
}
