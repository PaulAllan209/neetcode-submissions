public class TrieNode {
    public Dictionary<char, TrieNode> children = new();
    public bool isEndOfWord;

    public TrieNode(bool isEndOfWord = false) {
        this.isEndOfWord = isEndOfWord;
    }
}

public class WordDictionary {
    private TrieNode wordDict = new();

    public WordDictionary() {
        
    }
    
    public void AddWord(string word) {
        var curr = wordDict;

        foreach (char c in word) {
            if (!curr.children.ContainsKey(c)) {
                curr.children[c] = new();
            }

            curr = curr.children[c];
        }

        curr.isEndOfWord = true;
    }
    
    public bool Search(string word) {
        return dfs(word, 0, wordDict);
    }

    private bool dfs(string word, int j, TrieNode root) {
        if (j == word.Length) return root.isEndOfWord;

        char c = word[j];

        if (c == '.') {
            foreach(var child in root.children.Values) {
                if (dfs(word, j + 1, child)) {
                    return true;
                }
            }
            return false;
        }
        else {
            if (root.children.ContainsKey(c)) {
                return dfs(word, j + 1, root.children[c]);
            }
            else {
                return false;
            }
        }

        return false;
    }

    
}
