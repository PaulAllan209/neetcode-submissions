public class Solution {
    public int CountSubstrings(string s) {
        int res = 0;

        for (int i = 0; i < s.Length; i++) {
            int l = i;
            int r = i;
            HashSet<string> counter = new();
            
            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                counter.Add(s[l..(r+1)]);
                l--;
                r++;
            }

            l = i;
            r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                counter.Add(s[l..(r+1)]);
                l--;
                r++;
            }

            res += counter.Count;
        }

        return res;
    }
}
