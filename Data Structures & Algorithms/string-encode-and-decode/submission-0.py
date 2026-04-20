class Solution:

    def encode(self, strs: List[str]) -> str:
        enc_str = ""

        for word in strs:
            enc_str += word + "|"
        
        return enc_str

    def decode(self, s: str) -> List[str]:
        str_to_append = ""
        list_to_return = []

        for c in s:
            if(c == "|"):
                list_to_return.append(str_to_append)
                str_to_append = ""
            else:
                str_to_append += c
        
        return list_to_return
        


