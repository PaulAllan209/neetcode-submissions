public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) return nums[0];

        return Math.Max(
            RobLinear(nums, 0, nums.Length - 1),
            RobLinear(nums, 1, nums.Length)
        );
    }

    private int RobLinear(int[] nums, int start, int end) {
        int oneBack = 0;
        int twoBack = 0;

        for (int i = start; i < end; i++) {
            var current = Math.Max(twoBack + nums[i], oneBack);
            twoBack = oneBack;
            oneBack = current;
        }        

        return oneBack;
    }
}
