public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> charCount = new();
        int l = 0;
        int res = 0;

        for(int r = 0; r < s.Length; r++) {
            char c = s[r];

            if (charCount.ContainsKey(c)) {
                charCount[c] += 1;
            }
            else {
                charCount[c] = 1;
            }

            int windowLen = r - l + 1;
            int max = 0;

            foreach(int val in charCount.Values) {
                max = Math.Max(max, val);
            }

            if ((windowLen - max) <= k) {
                res = Math.Max(res, windowLen);
            }
            else {
                while ((r - l + 1 - max) > k) {
                    charCount[s[l]] -= 1;
                    l++;
                }
            }
        }

        return res;
    }
}
