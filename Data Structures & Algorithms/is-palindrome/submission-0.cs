public class Solution {
    public bool IsPalindrome(string s) {
        string removedSpecial = new string(s.Where(char.IsLetterOrDigit).ToArray());
        string trimmed = removedSpecial.Trim().ToLower();


        for (int i=0; i < trimmed.Length; i++) {
            if(trimmed[i] == trimmed[trimmed.Length - i -1]){
                continue;
            }

            else {
                return false;
            }
        }

        return true;
    }
}
