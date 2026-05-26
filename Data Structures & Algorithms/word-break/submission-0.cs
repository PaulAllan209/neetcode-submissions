public class Solution {
    private Dictionary<string, bool> memo = new();
    public bool WordBreak(string s, List<string> wordDict) {
        return dfs(s, wordDict);
    }

    private bool dfs(string s, List<string> wordDict) {
        if (s.Length == 0) return true;

        if (memo.ContainsKey(s)) return memo[s];

        for(int i = 0; i < wordDict.Count; i++) {
            var word = wordDict[i];

            if (s.StartsWith(word)) {
                var result = dfs(s.Substring(word.Length), wordDict);

                if (result) {
                    memo[s] = true;
                    return memo[s];
                }
            }
        }

        memo[s] = false;
        return memo[s];
    }

}
