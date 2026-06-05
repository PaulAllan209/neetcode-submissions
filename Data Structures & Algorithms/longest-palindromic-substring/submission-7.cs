public class Solution {
    public string LongestPalindrome(string s) {
        if (s.Length == 1) return s[0].ToString();
        else if (s.Length == 0) return "";
        int p1 = 0;
        int p2 = 0;
        string res = "";

        for (int i = 0; i < s.Length; i++) {
            int l  = i;
            int r = i;

            // odd
            while (r < s.Length && l >= 0 && s[l] == s[r]) {
                if (res.Length < ((r - l) + 1)) {
                    res = s.Substring(l, (r - l) + 1);
                }
                l--;
                r++;
            }

            // even 
            l = i;
            r = i + 1;
            while (r < s.Length && l >= 0 && s[l] == s[r]) {
                if (res.Length < ((r - l) + 1)) {
                    res = s.Substring(l, (r - l) + 1);
                }

                l--;
                r++;
            }
        }

        return res;
    }
}
