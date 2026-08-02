public class Solution {
    public int MaxSubArray(int[] nums) {
        int res = nums[0];
        int currSum = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            currSum = Math.Max(nums[i], currSum + nums[i]);
            res = Math.Max(res, currSum);
        }

        return res;
    }
}
