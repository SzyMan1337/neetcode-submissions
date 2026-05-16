public class WordDictionary {
    public TrieNode root;
    public WordDictionary() {
        root= new TrieNode(); 
    }
    
    public void AddWord(string word) {
        var node = root;
        foreach(var c in word){
            if(node.Children['z'-c] == null){
                node.Children['z'-c] = new TrieNode();
            }
            node = node.Children['z'-c];
        }
        node.EndOfWord = true;
    }
    
    public bool Search(string word) {
        return DFS(word, 0, root);
    }

    public bool DFS(string word, int i, TrieNode node)
    {
        if(i == word.Length){
            return node.EndOfWord;
        }

        if(word[i] == '.'){
            foreach(var child in node.Children){
                if(child != null && DFS(word, i+1, child)){
                    return true;
                }
            }
            return false;
        }

        if(node.Children['z'-word[i]] !=null){
            return DFS(word, i+1, node.Children['z'-word[i]]);
        }
        return false;
    }
}

public class TrieNode 
{
    public bool EndOfWord {get; set;}
    public TrieNode[] Children {get; set;}

    public TrieNode()
    {
        EndOfWord = false;
        Children = new TrieNode[26];
    }
}
