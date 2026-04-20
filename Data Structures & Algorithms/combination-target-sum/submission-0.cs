public class Solution {
    List<List<int>> res = new();

    public List<List<int>> CombinationSum(int[] nums, int target) {
        Backtrack(0, new(), 0, nums, target);
        return res;
    }

    public void Backtrack(int i, List<int> curr, int total, int[] nums, int target) {
        if (total == target) {
            res.Add(curr.ToList());
            return;
        }

        if (total > target || i >= nums.Length) return;

        curr.Add(nums[i]);

        Backtrack(i, curr, total + nums[i], nums, target);
        curr.Remove(curr.Last());

        Backtrack(i + 1, curr, total, nums, target);
    }
}
