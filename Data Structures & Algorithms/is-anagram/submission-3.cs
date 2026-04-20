public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> char_nums1 = new Dictionary<char, int>();
        Dictionary<char, int> char_nums2 = new Dictionary<char, int>();

        foreach(char c in s){
            if(char_nums1.ContainsKey(c)){
                char_nums1[c] += 1;
            } else {
                char_nums1[c] = 1;
            }
        }

        foreach(char c in t){
            if(char_nums2.ContainsKey(c)){
                char_nums2[c] += 1;
            } else {
                char_nums2[c] = 1;
            }
        }

        if ((char_nums1.Count == char_nums2.Count) && (!char_nums1.Except(char_nums2).Any())){
            return true;
        } else {
            return false;
        }
    }
}
