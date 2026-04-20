class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        prefix_list = []
        suffix_list = []
        list_to_return = []

        for i in range(len(nums)):
            if(i == 0):
                prefix_list.append(nums[i])
            else:
                prefix_list.append(prefix_list[i-1] * nums[i])

        for i in range(len(nums) - 1, -1, -1):
            if(i == (len(nums) - 1)):
                suffix_list.append(nums[i])
            else:
                suffix_list.insert(0, suffix_list[0]*nums[i])

        for i in range(len(nums)):
            if(i == 0):
                list_to_return.append(suffix_list[i+1])
            elif(i == (len(nums) - 1)):
                list_to_return.append(prefix_list[i-1])
            else:
                list_to_return.append(prefix_list[i-1]*suffix_list[i+1])
        
        return list_to_return
