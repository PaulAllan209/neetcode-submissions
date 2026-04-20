public class Solution {
    List<string> res = new();

    public List<string> GenerateParenthesis(int n) {
        Backtrack(n, n, "");

        return res;
    }

    private void Backtrack(int l, int r, string curr) {
        if (l == 0 && r == 0) {
            res.Add(curr);
            return;
        }

        if (l == r) {
            Backtrack(l - 1, r, string.Concat(curr, "("));
            return;
        }

        if (l > 0) {
            Backtrack(l - 1, r, string.Concat(curr, "("));
        }

        if (r > 0) {
            Backtrack(l, r - 1, string.Concat(curr, ")"));
        }
    }
}
