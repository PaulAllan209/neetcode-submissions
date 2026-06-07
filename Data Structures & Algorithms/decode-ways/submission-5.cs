public class Solution {
    private Dictionary<string, int> memo = new();

    public int NumDecodings(string s) {
        return dfs(s);
    }

    private int dfs(string s) {
        if (s.Length == 0) return 1;
        if (s[0] == '0') return 0;

        if (memo.ContainsKey(s)) {
            return memo[s];
        }

        int oneDigit = dfs(s[1..]);
        int twoDigit = 0;
        if (s.Length >= 2) {
            int num = (s[0] - '0')*10 + (s[1] - '0');
            twoDigit = num <= 26 ? dfs(s[2..]) : 0;
        }

        memo[s] = oneDigit + twoDigit;
        return memo[s];
    }
}
