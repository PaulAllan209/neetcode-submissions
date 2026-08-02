public class Solution {
    public int MaxSubArray(int[] nums) {
        int res = nums[0];
        int currSum = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] < (currSum + nums[i])) {
                currSum += nums[i];
            }
            else {
                currSum = nums[i];
            }
            
            res = Math.Max(res, currSum);
        }

        return res;
    }
}
