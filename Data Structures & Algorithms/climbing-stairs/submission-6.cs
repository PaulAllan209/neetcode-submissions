public class Solution {
    private int n;
    private Dictionary<int, int> cache = new();

    public int ClimbStairs(int n) { 
        this.n = n;

        return dfs(0);
    }

    public int dfs(int curr) {
        if (curr == n) return 1;
        if (curr > n) {
            return 0;
        }

        if (cache.ContainsKey(curr)) {
            return cache[curr];
        }

        int res = dfs(curr + 1) + dfs(curr + 2);
        cache[curr] = res;
        return res;
    }
}
