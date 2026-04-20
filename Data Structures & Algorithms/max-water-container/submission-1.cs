public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length - 1;
        int res = 0;

        while(l < r) {
            int area = (Math.Min(heights[l], heights[r])) * (r - l);
            res = Math.Max(res, area);

            if(heights[l] <= heights[r]) {
                l++;
            }
            else {
                r--;
            }
        }

        return res;
    }
}
