public class Solution {
    private int res = 0;
    public int CountSubstrings(string s) {

        for (int i = 0; i < s.Length; i++) {
            int l = i;
            int r = i;

            // odd
            while (
                l >= 0
                && r < s.Length
                && s[l] == s[r]
            ) {
                res++;
                l--;
                r++;
            }

            // even
            l = i;
            r = i + 1;
            while (
                l >= 0
                && r < s.Length
                && s[l] == s[r]
            ) {
                res++;
                l--;
                r++;
            }
        }

        return res;
    }
}
