public class Solution {
    private string part = "";
    private List<string> res = new();
    private Dictionary<char, List<string>> map = new()
    {
        {'2', new() {"a", "b", "c"}},
        {'3', new() {"d", "e", "f"}},
        {'4', new() {"g", "h", "i"}},
        {'5', new() {"j", "k", "l"}},
        {'6', new() {"m", "n", "o"}},
        {'7', new() {"p", "q", "r", "s"}},
        {'8', new() {"t", "u", "v"}},
        {'9', new() {"w", "x", "y", "z"}}
    };

    public List<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) return new();
        dfs(0, digits);
        return res;
    }

    private void dfs(int digitsI, string digits) {
        if (digitsI >= digits.Length) {
            res.Add(part);
            return;
        }

        foreach(string c in map[digits[digitsI]]) {
            part = part + c;
            dfs(digitsI + 1, digits);
            part = part.Remove(part.Length - 1);
        }
    }
}
