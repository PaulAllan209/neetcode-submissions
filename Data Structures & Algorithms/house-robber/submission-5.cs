public class Solution {
    public int Rob(int[] nums) {
        int oneBack = 0;
        int twoBack = 0;

        for (int i = 0; i < nums.Length; i++) {
            var temp = Math.Max(oneBack, twoBack + nums[i]);
            twoBack = oneBack;
            oneBack = temp;
        }

        return oneBack;
    }
}
