public class Solution {
    private List<List<int>> res = new();
    private List<int> sol = new();
    private int[] nums;

    public List<List<int>> Subsets(int[] nums) {
        this.nums = nums;

        backtrack(0);
        return res;
    }

    public void backtrack(int index) {
        if (index >= nums.Length) {
            res.Add(sol.ToList());
            return;
        }

        // choose the num
        sol.Add(nums[index]);
        backtrack(index + 1);

        sol.RemoveAt(sol.Count - 1);
        // do not choose the num
        backtrack(index + 1);
    }
}
