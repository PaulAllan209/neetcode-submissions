public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> charMap = new();
        Dictionary<char, int> seen = new();
        int have = 0;
        int l = 0;
        (string, int) res = ("", int.MaxValue);

        foreach(char c in t) {
            if (charMap.ContainsKey(c)) {
                charMap[c] += 1;
            }
            else {
                charMap[c] = 1;
            }
        }
        int need = charMap.Count;

        for (int r = 0; r < s.Length; r++) {
            if (charMap.ContainsKey(s[r])) {
                if (seen.ContainsKey(s[r])) {
                    seen[s[r]] += 1;
                }
                else {
                    seen[s[r]] = 1;
                }
                if (charMap[s[r]] == seen[s[r]]) {
                    have++;
                }
            }

            while (need == have) {
                if ((r - l + 1) < res.Item2) {
                    res = (s[l..(r+1)], r - l + 1);
                }

                if (seen.ContainsKey(s[l])) {
                    seen[s[l]] -= 1;

                    if (charMap[s[l]] > seen[s[l]]) {
                        have--;
                    }
                }

                l++;
            }
        }

        return res.Item1;
    }
}
