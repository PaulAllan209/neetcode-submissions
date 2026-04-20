public class TrieNode {
    public Dictionary<char, TrieNode> children = new();
    public bool endOfWord = false;
}

public class PrefixTree {
    public TrieNode root = new();

    public PrefixTree() {
        
    }
    
    public void Insert(string word) {
        var curr = root;
        foreach(char c in word) {
            if (curr.children.ContainsKey(c)) {
                curr = curr.children[c];
            }
            else {
                curr.children[c] = new();
                curr = curr.children[c];
            }
        }

        curr.endOfWord = true;
    }
    
    public bool Search(string word) {
        var curr = root;

        foreach (char c in word) {
            if (curr.children.ContainsKey(c)) {
                curr = curr.children[c];
            }
            else {
                return false;
            }
        }

        return curr.endOfWord;
    }
    
    public bool StartsWith(string prefix) {
        var curr = root;

        foreach (char c in prefix) {
            if (curr.children.ContainsKey(c)) {
                curr = curr.children[c];
            }
            else {
                return false;
            }
        }

        return true;
    }
}
