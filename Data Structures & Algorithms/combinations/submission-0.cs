public class Solution {
    public List<List<int>> Combine(int n, int k) {
        var result = new List<List<int>>();

        Backtrack(n, 1, k, result, new List<int>());

        return result;
    }

    private void Backtrack(int n, int i, int k, List<List<int>> result, List<int> currentList) {
        if(currentList.Count == k){
            result.Add(new List<int>(currentList));
            return;
        }

        if(i>n){
            return;
        }

        currentList.Add(i);
        Backtrack(n,i+1,k,result,currentList);
        currentList.Remove(i);
        Backtrack(n,i+1,k,result,currentList);
    }
}