public class Solution {
    public int Rob(int[] nums) {
        int prev1 = 0;
        int prev2 = 0;

        for (int i = 0; i < nums.Length; i++) {
            var temp = Math.Max(prev1 + nums[i], prev2);
            prev1 = prev2;
            prev2 = temp;
        }

        return prev2;
    }
}
