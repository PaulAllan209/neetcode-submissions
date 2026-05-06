public class Solution {
    public string LongestPalindrome(string s) {
        string res = "";

        for (int i = 0; i < s.Length; i++) {
            int l = i;
            int r = i;
            // Odd palindrome
            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                if ((r - l + 1) > res.Length) {
                    res = s[l..(r+1)];
                }
                l--;
                r++;
            }

            // even palindrome
            l = i;
            r = i + 1;
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
