public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int maxNum = piles.Max();

        int l = 1;
        int r = maxNum;
        int res = maxNum;

        while (l <= r) {
            int p = (l + r) / 2;

            long hTemp = 0;
            for (int i = 0; i < piles.Length; i++) {
                hTemp += (int)Math.Ceiling((double)piles[i] / p);
            }

            if(hTemp <= h) {
                res = p;
                r = p - 1;
            }
            else {
                l = p + 1;
            }
        }

        return res;
    }
}
