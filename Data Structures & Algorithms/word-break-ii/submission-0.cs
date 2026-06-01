public class Solution {
    private Dictionary<int, List<string>> cache = new Dictionary<int, List<string>>();

    public List<string> WordBreak(string s, List<string> wordDict) {
        Trie trie = new Trie();
        foreach (string word in wordDict) {
            trie.AddWord(word);
        }
        return Backtrack(0, s, trie.Root, trie);
    }

    private List<string> Backtrack(int index, string s, TrieNode root, Trie trie) {
        if (index == s.Length) return new List<string> { "" };
        if (cache.ContainsKey(index)) return cache[index];

        List<string> res = new List<string>();
        TrieNode curr = root;

        for (int i = index; i < s.Length; i++) {
            char c = s[i];
            if (!curr.Children.ContainsKey(c)) break;

            curr = curr.Children[c];
            if (curr.IsWord) {
                List<string> suffixes = Backtrack(i + 1, s, root, trie);
                foreach (string suffix in suffixes) {
                    if (suffix == "") {
                        res.Add(s.Substring(index, i - index + 1));
                    } else {
                        res.Add(s.Substring(index, i - index + 1) + " " + suffix);
                    }
                }
            }
        }

        cache[index] = res;
        return res;
    }
}


public class TrieNode {
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    public bool IsWord = false;
}

public class Trie {
    public TrieNode Root = new TrieNode();

    public void AddWord(string word) {
        TrieNode curr = Root;
        foreach (char c in word) {
            if (!curr.Children.ContainsKey(c)) {
                curr.Children[c] = new TrieNode();
            }
            curr = curr.Children[c];
        }
        curr.IsWord = true;
    }
}
