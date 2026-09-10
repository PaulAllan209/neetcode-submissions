public class Solution {
    public int ClimbStairs(int n) {
        if (n == 1) return 1;
        if (n == 2) return 2;

        int prev = 1;
        int curr = 2;

        for (int i = 3; i <= n; i++) {
            var temp = prev + curr;
            prev = curr;
            curr = temp;
        }

        return curr;
    }
}
