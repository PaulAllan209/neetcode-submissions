public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) return nums[0];

        int prev1 = 0;
        int prev2 = 0;

        for(int i = 0; i < nums.Length; i++) {
            int temp = prev1;
            prev1 = Math.Max(nums[i] + prev2, prev1);
            prev2 = temp;
        }

        return prev1; 
    }
}
