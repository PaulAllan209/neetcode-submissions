public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;
        int res = 0;

        for(int r = 0; r < prices.Length; r++) {
            res = Math.Max(prices[r] - prices[l], res);
            if (prices[r] < prices[l]) {
                l = r;
            }
        }

        return res;
    }
}
