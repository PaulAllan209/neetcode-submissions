public class Solution {
    public int MaxProfit(int[] prices) {
        int res = 0;
        int l = 0;

        for (int r = 0; r < prices.Length; r++) {
            res = Math.Max(res, prices[r] - prices[l]);

            if (prices[r] < prices[l]) {
                l = r;
            }
        }

        return res;
    }
}
