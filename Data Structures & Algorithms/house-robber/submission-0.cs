public class Solution {
    private Dictionary<int, int> memo = new();
    private int[] nums;
    private int res = 0;

    public int Rob(int[] nums) {
        this.nums = nums;

         
        return dfs(0);
    }

    private int dfs(int index) {
        if (index >= nums.Length) {
            return 0;
        }

        if (memo.ContainsKey(index)) {
            return memo[index];
        }

        int rob = nums[index] + dfs(index + 2);
        int skip = dfs(index + 1);

        int res =  Math.Max(rob, skip);
        memo[index] = res;
        return res;
    }


}
