public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> values = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (values.ContainsKey(nums[i])) {
                return true;
            }
            values.Add(nums[i], 1);
        }

        return false;
    }
}