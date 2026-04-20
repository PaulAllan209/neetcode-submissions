class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        ret_dict = defaultdict(int)

        for i in nums:
            if (i in ret_dict):
                ret_dict[i] += 1
            else:
                ret_dict[i] = 1
        
        return sorted(ret_dict, key=ret_dict.get, reverse=True)[:k]
        