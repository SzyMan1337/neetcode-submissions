public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        var characters = new Dictionary<char, int>();
        int l = 0, longest = 0, maxf = 0;

        for (int r = 0; r < s.Length; r++)
        {
            if (!characters.ContainsKey(s[r]))
            {
                characters.Add(s[r], 1);
            }
            else
            {
                characters[s[r]]++;
            }
            maxf = Math.Max(maxf, characters[s[r]]);

            if((r - l + 1) - maxf <= k){
                longest = Math.Max(longest, r - l + 1);
            }

            while ((r - l + 1) - maxf > k)
            {
                characters[s[l]]--;
                l++;
            }
        }

        return longest;
    }
}
