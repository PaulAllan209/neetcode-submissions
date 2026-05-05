public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) return nums[0];

        return Math.Max(
            RobLinear(nums, 0, nums.Length - 1),
            RobLinear(nums, 1, nums.Length)
        );
    }

    private int RobLinear(int[] nums, int start, int end) {
        int prev1 = 0;
        int prev2 = 0;

        for (int i = start; i < end; i++) {
            int temp = prev1;
            prev1 = Math.Max(nums[i] + prev2, prev1);
            prev2 = temp;
        }

        return prev1;
    } 
}
