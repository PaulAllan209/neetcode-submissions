public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        int p = (r + l) / 2;

        while (l <= r) {
            if (nums[p] == target) {
                return p;
            }
            else if (nums[p] < target) {
                l = p + 1;
            }
            else if (nums[p] > target) {
                r = p - 1;
            }
            p = (r + l) / 2;
        }

        return -1;
    }
}
