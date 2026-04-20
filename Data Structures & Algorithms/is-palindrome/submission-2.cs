public class Solution {
    public bool IsPalindrome(string s) {
        int p1 = 0;
        int p2 = s.Length - 1;

        while (p1 < p2) {
            while (p1 < p2 && !AlphaNum(s[p1])) {
                p1 += 1;
            }

            while (p1 < p2 && !AlphaNum(s[p2])) {
                p2 -= 1;
            }

            if (char.ToLower(s[p1]) != char.ToLower(s[p2])) {
                return false;
            }

            p1 += 1;
            p2 -= 1;
        }

        return true;
    }

    private bool AlphaNum(char c) {
        return (c >= 'A' && c <= 'Z') ||
            (c >= 'a' && c <= 'z') ||
            (c >= '0' && c <= '9');
    }
}
