public class Solution {
    private Dictionary<int, int> memo = new();

    public int ClimbStairs(int n) {     
        return dfs(n);
    }

    private int dfs(int remainingSteps) {
        if (remainingSteps == 0) return 1;
        if (remainingSteps < 0) return 0;

        if (memo.ContainsKey(remainingSteps)) {
            return memo[remainingSteps];
        }

        memo[remainingSteps] = dfs(remainingSteps - 1) + dfs(remainingSteps - 2);

        return memo[remainingSteps];
    }
}
