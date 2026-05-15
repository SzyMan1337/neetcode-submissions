public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if(hand.Length % groupSize != 0){
            return false;
        }

        List<List<int>> groups = new();
        var groupsNum = hand.Length / groupSize;

        for (int k = 0; k < groupsNum; k++) {
            groups.Add(new List<int>());
        }

        Array.Sort(hand);
        int firstValidGroup = 0;
        int lastNum = -1;
        int i = 0;

        while (i < hand.Length) {
            var num = hand[i];
            if (lastNum != -1 && lastNum + 1 != num && groups[firstValidGroup].Count > 0) {
                return false;
            }
            groups[firstValidGroup].Add(num);
            int j = i + 1;
            int groupId = firstValidGroup + 1;

            while (j < hand.Length && num == hand[j]) {
                if (groupId == groupsNum) {
                    return false;
                }

                groups[groupId].Add(num);
                j++;
                groupId++;
            }

            while (firstValidGroup < groupsNum && groups[firstValidGroup].Count == groupSize) {
                firstValidGroup++;
            }

            if (firstValidGroup < groupsNum && groups[firstValidGroup].Count >0) {
                lastNum = groups[firstValidGroup].Last();
            }
            i = j;
        }

        return true;
    }
}
