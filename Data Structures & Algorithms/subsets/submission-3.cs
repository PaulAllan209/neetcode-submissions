public class Solution {
    private List<List<int>> res = new();
    private List<int> sol = new();
    private int[] nums;

    public List<List<int>> Subsets(int[] nums) {
        this.nums = nums;
        backtrack(0);
        return res;
    }

    private void backtrack(int index) {
        if (index >= nums.Length) {
            res.Add(sol.ToList());
            return;
        }

        // choose index
        sol.Add(nums[index]);
        backtrack(index + 1);

        // do not choose index
        sol.RemoveAt(sol.Count - 1);
        backtrack(index + 1);
    }
}
