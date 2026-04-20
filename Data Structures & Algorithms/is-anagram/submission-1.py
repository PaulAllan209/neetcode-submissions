class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        str_hash1 = {}
        str_hash2 = {}

        for i in list(s):
            if(i in str_hash1):
                str_hash1[i] += 1
            else:
                str_hash1[i] = 1
        
        for i in list(t):
            if(i in str_hash2):
                str_hash2[i] += 1
            else:
                str_hash2[i] = 1
        
        return ( str_hash1 == str_hash2 )
        