class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        count = {}
        frequency = [[] for i in range(len(nums) + 1)]

        for i in nums:
            count[i] = 1 + count.get(i, 0)
        
        for key, value in count.items():
            frequency[value].append(key)
        
        res = []

        for i in range(len(frequency) - 1, 0, -1):
            for num in frequency[i]:
                res.append(num)
                if(len(res) == k):
                    return res

        