class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        res = defaultdict(list)

        for s in strs:
            ref = [0] * 26
            for c in s:
                ref[ord(c) - ord("a")] += 1
            res[tuple(ref)].append(s)
        
        return res.values()