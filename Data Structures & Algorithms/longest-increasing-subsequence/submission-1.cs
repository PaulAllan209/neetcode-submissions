public class Solution {
    private int res = 0;
    private Dictionary<int, int> memo = new();

    public int LengthOfLIS(int[] nums) {
        int res = 0;

        for (int i = 0; i < nums.Length; i++) {
            res = Math.Max(res, dfs(nums, nums[i], i) + 1);
        }

        return res;
    }

    private int dfs(int[] nums, int lastNum, int lastIndex) {
        if (memo.ContainsKey(lastIndex)) return memo[lastIndex];
        int res = 0;

        for (int i = lastIndex + 1; i < nums.Length; i++) {
            if (nums[i] > lastNum) {
                res = Math.Max(res, dfs(nums, nums[i], i) + 1);
            }
        }

        memo[lastIndex] = res;
        return memo[lastIndex];
    }
}
