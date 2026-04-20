public class Solution {
    List<string> res = new();

    public List<string> GenerateParenthesis(int n) {
        char[] curr = new char[2 * n];
        Backtrack(n, n, 0, curr);

        return res;
    }

    private void Backtrack(int l, int r, int i, char[] curr) {
        if (l == 0 && r == 0) {
            res.Add(new string(curr));
            return;
        }

        if (l > 0) {
            curr[i] = '(';
            Backtrack(l - 1, r, i + 1, curr);
        }

        if (r > l) {
            curr[i] = ')';
            Backtrack(l, r - 1, i + 1, curr);
        }
    }
}
