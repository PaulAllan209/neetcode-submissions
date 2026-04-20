class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        frequency = {}
        nums_list = [[] for _ in range(len(nums) + 1)]
        list_to_return = []

        for num in nums:
            frequency[num] = frequency.get(num, 0) + 1
        
        for key, value in frequency.items():
            nums_list[value].append(key)
        
        for i in range(len(nums_list)-1, 0, -1):
            for i2 in range(len(nums_list[i]), 0, -1):
                list_to_return.append(nums_list[i][i2-1])
                if (len(list_to_return) == k):
                    return list_to_return


        