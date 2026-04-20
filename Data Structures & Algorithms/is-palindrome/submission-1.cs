public class Solution {
    public bool IsPalindrome(string s) {
        string filtered = new string(s
            .Where(x => char.IsLetterOrDigit(x))
            .Select(x => char.ToLowerInvariant(x))
            .ToArray())
            .Replace(" ", "");

        int p1 = 0;
        int p2 = filtered.Length - 1;

        while (p1 <= p2) {
            if (filtered[p2] != filtered[p1]) {
                return false;
            }
            p1 += 1;
            p2 -= 1;
        }

        return true;
    }
}
