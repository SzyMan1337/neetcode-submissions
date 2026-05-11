public class Solution {
    public uint ReverseBits(uint n) {
        uint result = 0;

        for(int i =31; i>=0;i--){
            int j = 31-i;
            result |= ((1 & (n>>j)) << i);
        }

        return result;
    }
}
