public class Solution {
    private Dictionary<int, int?> memo = new();

    public int CoinChange(int[] coins, int amount) {
        int? res = dfs(coins, amount);

        return res.HasValue ? (int)res : -1;
    }

    private int? dfs(int[] coins, int amount) {
        if (amount < 0) return null;
        if (amount == 0) return 0;

        if (memo.ContainsKey(amount)) return memo[amount];

        int? res = null;
        foreach(int coin in coins) {
            int? result = dfs(coins, amount - coin);

            if (result.HasValue && (res == null || (result + 1) < res)) {
                res = result + 1;
            }
        }
        
        memo[amount] = res;
        return memo[amount];
    }
}
