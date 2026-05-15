public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        bool a =false, b =false, c =false;

        foreach(var triplet in triplets){
            if(target[0] == triplet[0] && triplet[1] <= target[1] && triplet[2] <= target[2]){
                a = true;
            }

            if(target[1] == triplet[1] && triplet[0] <= target[0] && triplet[2] <= target[2]){
                b= true;
            }

            if(target[2] == triplet[2] && triplet[1] <= target[1] && triplet[0] <= target[0]){
                c = true;
            }
        }

        return a && b && c;
    }
}
