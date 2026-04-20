public class Solution {
    public int FindDuplicate(int[] nums) {
        int sp1 = 0;
        int fp = 0;
        int sp2 = 0;

        sp1 = nums[0];
        fp = nums[nums[0]];
        while (sp1 != fp) {
            sp1 = nums[sp1];
            fp = nums[nums[fp]];

            if (sp1 == fp) {
                break;
            }
        }

        while (sp1 != sp2) {
            sp1 = nums[sp1];
            sp2 = nums[sp2];

            if (sp1 == sp2) {
                break;
            }
        }

        return sp1;
    }
}
