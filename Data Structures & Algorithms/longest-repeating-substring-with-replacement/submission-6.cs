public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> seen = new();

        int l = 0;
        int res = 0;

        for (int r = 0; r < s.Length; r++) {
            if (seen.ContainsKey(s[r])) {
                seen[s[r]] += 1;
            }
            else {
                seen[s[r]] = 1;
            }

            while ((r - l + 1 - seen.Values.Max()) > k) {
                seen[s[l]] -= 1;
                l++;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
