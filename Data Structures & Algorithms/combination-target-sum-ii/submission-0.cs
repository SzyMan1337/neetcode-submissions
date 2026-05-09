public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        var result = new List<List<int>>();
        Backtrack(result, new List<int>(), target, candidates, 0);

        return result;
    }

    public void Backtrack(List<List<int>> result, List<int> currentList, int currentTarget, int[] candidates, int index)
    {
        if(currentTarget == 0){
            result.Add(new(currentList));
            return;
        }
        if(index >= candidates.Length || currentTarget - candidates[index] < 0){
            return;
        }

        var el = candidates[index];
        int i = 0;
        while(index+i < candidates.Length && el == candidates[index+i]){
            currentList.Add(el);
            i++;
        }
        for(int j =i; j>0; j--)
        {
            Backtrack(result, currentList, currentTarget - el*j, candidates, index+i);
            currentList.RemoveAt(currentList.Count - 1);
        }
        Backtrack(result, currentList, currentTarget, candidates, index+i);
    }
}
