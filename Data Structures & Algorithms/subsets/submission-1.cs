public class Solution {
    List<List<int>> res = new();

    public List<List<int>> Subsets(int[] nums) {
        Backtrack(new(), nums, 0);
        return res;
    }

    private void Backtrack(List<int> curr, int[] nums, int i) {
        if (i >= nums.Length) {
            res.Add(curr.ToList());
            return;
        }

        Backtrack(curr, nums, i + 1);

        curr.Add(nums[i]);
        Backtrack(curr, nums, i + 1);
        curr.RemoveAt(curr.Count - 1);
    }
}
