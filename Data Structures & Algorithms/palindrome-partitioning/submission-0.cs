public class Solution {
    private List<string> part = new();
    private List<List<string>> res = new();

    public List<List<string>> Partition(string s) {
        dfs(0, s);
        return res;
    }

    private void dfs(int j, string s) {
        if (j >= s.Length) {
            res.Add(part.ToList());
            return;
        }

        for (int i = j; i < s.Length; i++) {
            if (isPali(j, i, s)) {
                part.Add(s[j..(i+1)]);
                dfs(i+1, s);
                part.RemoveAt(part.Count - 1);
            }
        }
    }

    private bool isPali(int l, int r, string s) {
        while (l < r) {
            if (s[l] != s[r]) return false;
            l++;
            r--;
        }

        return true;
    }
}
