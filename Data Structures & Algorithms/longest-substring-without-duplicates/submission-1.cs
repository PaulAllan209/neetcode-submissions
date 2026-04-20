public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> charSet = new();
        int l = 0;
        int maxCount = 0;

        for (int r = 0; r < s.Length; r++) {
            while (charSet.Contains(s[r])) {
                charSet.Remove(s[l]);
                l++;
            }
            
            charSet.Add(s[r]);
            maxCount = Math.Max(maxCount, r - l + 1);
        }

        return maxCount;
    }
}
