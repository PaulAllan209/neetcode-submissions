public class Solution {
    private List<List<int>> res = new();
    private List<int> sol = new();
    private int[] nums;
    private int target;

    public List<List<int>> CombinationSum(int[] nums, int target) {
        this.nums = nums;
        this.target = target;

        backtrack(0, 0);
        return res;
    }

    private void backtrack(int index, int currSum) {
        if (target == currSum) {
            res.Add(sol.ToList());
            return;
        }

        if (index >= nums.Length || target < currSum) {
            return;
        }

        // choose num
        sol.Add(nums[index]);
        backtrack(index, currSum + nums[index]);

        // do not choose num
        sol.RemoveAt(sol.Count - 1);
        backtrack(index + 1, currSum);
    }
}
