public class Solution {
    private List<List<int>> res = new();

    public List<List<int>> CombinationSum(int[] nums, int target) {
        Dfs(0, new(), 0, nums, target);
        return res;
    }

    private void Dfs(int i, List<int> curr, int sum, int[] nums, int target) {
        if (sum == target) {
            res.Add(curr.ToList());
            return;
        }

        if (i >= nums.Length || sum > target) {
            return;
        }

        curr.Add(nums[i]);
        Dfs(i, curr, sum + nums[i], nums, target);

        curr.RemoveAt(curr.Count - 1);
        
        Dfs(i + 1, curr, sum, nums, target);
    }
}
