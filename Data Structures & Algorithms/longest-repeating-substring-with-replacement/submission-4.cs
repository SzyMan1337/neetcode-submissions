public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        var characters = new Dictionary<char, int>();
        int l = 0;
        int longest = 0;
        int maxf = 0;

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
            int len = r - l + 1;

            if (k + maxf >= len)
            {
                longest = Math.Max(longest, len);
            }
            else
            {
                do
                {
                    characters[s[l]]--;
                    l++;
                } while (k + maxf < r - l + 1);
            }
        }

        return longest;
    }
}
