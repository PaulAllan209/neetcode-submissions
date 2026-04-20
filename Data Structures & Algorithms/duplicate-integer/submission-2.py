class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        p1 = 0
        dup_array = []

        while p1 <= len(nums) - 1:
            if(nums[p1] in dup_array):
                return True
            else:
                dup_array.append(nums[p1])
                p1 += 1
        return False
         