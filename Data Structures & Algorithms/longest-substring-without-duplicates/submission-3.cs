public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hashChar = new();
        int res = 0;
        int l = 0;

        for (int r = 0; r < s.Length; r++) {
            while (hashChar.Contains(s[r])) {
                hashChar.Remove(s[l]);
                l++;
            }

            hashChar.Add(s[r]);

            res = Math.Max(res, hashChar.Count);
        }

        return res;
    }
}
