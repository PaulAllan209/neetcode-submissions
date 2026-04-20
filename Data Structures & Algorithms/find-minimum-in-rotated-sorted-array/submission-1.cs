public class Solution {
    public int FindMin(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        int res = nums[0];

        while (l <= r) {
            if(nums[l] < nums[r]) {
                res = Math.Min(nums[l], res);
                break;
            }

            int p = (l + r)/2;
            res = Math.Min(nums[p], res);
            if(nums[p] >= nums[l]) {
                l = p + 1;
            }
            else {
                r = p - 1;
            }

        }

        return res;
    }
}
