public class Solution {
    public List<int> PartitionLabels(string s) {
        Dictionary<char,int> charMap = new();

        foreach(var c in s){
            if(!charMap.ContainsKey(c)){
                charMap.Add(c,0);
            }
            charMap[c]++;
        }

        var result = new List<int>();
        var currentPartition = new HashSet<char>();
        int counter = 0;

        for(int i =0; i<s.Length; i++){

            counter++;
            if(!currentPartition.Contains(s[i])){
                currentPartition.Add(s[i]);
            }

            charMap[s[i]]--;
            if(charMap[s[i]] == 0){
                currentPartition.Remove(s[i]);
            }

            if(currentPartition.Count == 0){
                result.Add(counter);
                counter = 0;
            }   
        }

        return result;
    }
}
