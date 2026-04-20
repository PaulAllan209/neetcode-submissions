public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l = 0;
        int r = 0;
        int res = 0;
        Dictionary<char, int> charHash = new();

        while (r < s.Length) {
            if (charHash.TryGetValue(s[r], out var count)) {
                charHash[s[r]] += 1;
            }
            else {
                charHash[s[r]] = 1;
            }
            
            var maxCount = 0;
            var maxKey = ' ';

            foreach(var kvp in charHash) {
                if (kvp.Value > maxCount) {
                    maxCount = kvp.Value;
                    maxKey = kvp.Key;
                }
            }
            
            var windowLen = r - l + 1;
            if ((windowLen - maxCount) <= k) {
                res = Math.Max(res, windowLen);
            }
            else {
                charHash[s[l]] -= 1;
                l++;
            }
            r++;
        }

        return res;
    }
}
