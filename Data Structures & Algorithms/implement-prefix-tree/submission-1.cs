public class Node {
    public Dictionary<char, Node> values = new();
    public bool isEndWord = false;

    public Node() { }
}
public class PrefixTree {
    Node root = new();

    public PrefixTree() {
        
    }
    
    public void Insert(string word) {
        var currNode = root;

        foreach(char c in word) {
            if (!currNode.values.ContainsKey(c)) {
                currNode.values[c] = new Node();
            }

            currNode = currNode.values[c];
        }
        currNode.isEndWord = true;
    }
    
    public bool Search(string word) {
        var currNode = root;

        foreach(char c in word) {
            if (!currNode.values.ContainsKey(c)) {
                return false;
            }

            currNode = currNode.values[c];
        }

        return currNode.isEndWord;
    }
    
    public bool StartsWith(string prefix) {
        var currNode = root;

        foreach(char c in prefix) {
            if (!currNode.values.ContainsKey(c)) {
                return false;
            }
            
            currNode = currNode.values[c];
        }

        return true;
    }
}
