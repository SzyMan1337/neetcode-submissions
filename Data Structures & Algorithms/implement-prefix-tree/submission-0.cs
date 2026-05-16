public class PrefixTree {
    public TrieNode root;

    public PrefixTree() {
        root= new TrieNode();
    }
    
    public void Insert(string word) {
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
        var node = root;

        foreach(var c in word){
            if(node.Children['z'-c] == null){
                return false;
            }
            node = node.Children['z'-c];
        }

        return node.EndOfWord;
    }
    
    public bool StartsWith(string prefix) {
        var node = root;

        foreach(var c in prefix){
            if(node.Children['z'-c] == null){
                return false;
            }
            node = node.Children['z'-c];
        }
        
        return true;
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
