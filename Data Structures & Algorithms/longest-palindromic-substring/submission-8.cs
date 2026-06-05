public class Solution {
    public string LongestPalindrome(string s) {
        string res = "";

        for (int i = 0; i < s.Length; i++) {
            int l  = i;
            int r = i;

            // odd
            while (r < s.Length && l >= 0 && s[l] == s[r]) {
                if (res.Length < ((r - l) + 1)) {
                    res = s[l..(r+1)];
                }
                l--;
                r++;
            }

            // even 
            l = i;
            r = i + 1;
            while (r < s.Length && l >= 0 && s[l] == s[r]) {
                if (res.Length < ((r - l) + 1)) {
                    res = s[l..(r+1)];
                }

                l--;
                r++;
            }
        }

        return res;
    }
}
