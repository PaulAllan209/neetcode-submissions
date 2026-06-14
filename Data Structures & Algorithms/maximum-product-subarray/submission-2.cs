public class Solution {
    public int MaxProduct(int[] nums) {
        int res = nums.Max();

        int min = 1;
        int max = 1;

        for (int i = 0; i < nums.Length; i++) {

            if (nums[i] == 0) {
                min = 1;
                max = 1;
            }
            else {
                var temp = max * nums[i];
                max = Math.Max(nums[i], Math.Max(min * nums[i], temp));
                min = Math.Min(nums[i], Math.Min(min * nums[i], temp));

                res = Math.Max(res, max);
            }
        }
        
        return res;
    }
}
