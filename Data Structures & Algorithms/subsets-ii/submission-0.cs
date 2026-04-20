public class Solution {
    List<List<int>> res = new();

    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        Backtrack(nums, 0, new());
        return res;
    }

    private void Backtrack(int[] nums, int i, List<int> curr) {
        if (i >= nums.Length) {
            res.Add(curr.ToList());
            return;
        }

        curr.Add(nums[i]);
        Backtrack(nums, i + 1, curr);
        curr.RemoveAt(curr.Count - 1);

        while((i + 1) < nums.Length && nums[i] == nums[i + 1]) {
            i++;
        }

        Backtrack(nums, i + 1, curr);
    }
}