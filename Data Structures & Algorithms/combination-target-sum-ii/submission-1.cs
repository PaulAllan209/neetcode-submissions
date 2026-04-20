public class Solution {
    List<List<int>> res = new();

    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        Dfs(0, new(), candidates, 0, target);
        return res;
    }

    private void Dfs(int i, List<int> curr, int[] nums, int sum, int target) {
        if (sum == target) {
            res.Add(curr.ToList());
            return;
        }

        if (i >= nums.Length || sum > target) return;

        curr.Add(nums[i]);
        Dfs(i + 1, curr, nums, sum + nums[i], target);
        curr.RemoveAt(curr.Count - 1);

        while ((i + 1) < nums.Length && nums[i] == nums[i + 1]) {
            i++;
        }

        Dfs(i + 1, curr, nums, sum, target);
    }
}
