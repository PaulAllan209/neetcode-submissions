public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        Dictionary<char, int> count1 = new();
        Dictionary<char, int> count2 = new();
        int s1Len = s1.Length;
        int l = 0;

        foreach (var c in s1) {
            if (count1.ContainsKey(c)) {
                count1[c] += 1;
            }
            else {
                count1[c] = 1;
            }
        }  

        for(int r = 0; r < s2.Length; r++) {
            if (count2.ContainsKey(s2[r])) {
                count2[s2[r]] += 1;
            }
            else {
                count2[s2[r]] = 1;
            }

            while((r - l + 1) > s1Len) {
                if (count2.ContainsKey(s2[l])) {
                    count2[s2[l]] -= 1;
                }

                l++;
            }
            
            if ((r - l + 1) == s1Len) {
                bool res = true;
                foreach (var pair in count1) {
                    if (!count2.ContainsKey(pair.Key) || count2[pair.Key] != pair.Value) {
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
