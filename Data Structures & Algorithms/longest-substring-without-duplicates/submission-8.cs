public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0;
        HashSet<int> seen = new();
        int max = 0;

        for(int r = 0; r < s.Length; r++) {
            while (seen.Contains(s[r])) {
                max = Math.Max(seen.Count, max);
                seen.Remove(s[l]);
                l++;
            }

            seen.Add(s[r]);
        }
        
        max = Math.Max(seen.Count, max);
        return max;
    }
}
