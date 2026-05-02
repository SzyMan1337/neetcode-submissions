public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();

        foreach(var s in strs){
            sb.Append(s.Length);
            sb.Append('_');
            sb.Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int i =0;

        while(i<s.Length){
            int j = i;
            while(s[j] != '_'){
                j++;
            }
            int l = int.Parse(s.Substring(i, j-i));
            i = j+1;
            j = i +l;
            result.Add(s.Substring(i, l));
            i = j;
        }

        return result;
   }
}
