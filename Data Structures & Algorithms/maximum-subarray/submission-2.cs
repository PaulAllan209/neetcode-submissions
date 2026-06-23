public class Solution {
    public int MaxSubArray(int[] nums) {
        int bestSum = nums[0];
        int currSum = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            currSum = Math.Max(currSum + nums[i], nums[i]);
            bestSum = Math.Max(currSum, bestSum);
        }

        return bestSum;
    }
}
