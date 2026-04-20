public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int l = 0;
        Dictionary<char, int> seen = new();
        Dictionary<char, int> charMap = new();

        int s1Len = s1.Length;

        foreach(char c in s1) {
            if (charMap.ContainsKey(c)) {
                charMap[c] += 1;
            }
            else {
                charMap[c] = 1;
            }
        }

        for (int r = 0; r < s2.Length; r++) {
            if (seen.ContainsKey(s2[r])) {
                seen[s2[r]] += 1;
            }
            else {
                seen[s2[r]] = 1;
            }
            
            while((r - l + 1) > s1Len) {
                if (seen.ContainsKey(s2[l])) {
                    seen[s2[l]] -= 1;
                }
                l++;
            }

            if ((r - l + 1) == s1Len) {
                bool res = true;
                foreach(var pair in charMap) {
                    if (!seen.ContainsKey(pair.Key) || seen[pair.Key] != pair.Value) {
                        res = false;
                        break;
                    }
                }

                if (res) return true;
            }
        }

        return false;
    }
}
