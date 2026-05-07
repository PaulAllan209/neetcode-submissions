public class Solution {
    public string LongestPalindrome(string s) {
        string res = "";

        for (int i = 0; i < s.Length; i++) {
            int l = i;
            int r = i;
            // odd
            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                if ((r - l + 1) > res.Length) {
                    res = s[l..(r+1)];
                }

                l--;
                r++;
            }

            l = i;
            r = i + 1;
            // even
            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                if ((r - l + 1) > res.Length) {
                    res = s[l..(r+1)];
                }
                l--;
                r++;
            }
        }

        return res;        
    }
}
