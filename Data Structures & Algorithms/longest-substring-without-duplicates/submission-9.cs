public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0;
        HashSet<int> seen = new();
        int max = 0;

        for(int r = 0; r < s.Length; r++) {
            while (seen.Contains(s[r])) {
                seen.Remove(s[l]);
                l++;
            }

            seen.Add(s[r]);
            max = Math.Max(r - l + 1, max);
        }
        
        return max;
    }
}
