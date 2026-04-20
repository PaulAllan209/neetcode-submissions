class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        p1 = 0
        p2 = 1

        while (p1 <= len(nums) - 1):
            if((nums[p1] + nums[p2]) == target):
                return [p1, p2]
            elif(p2 == (len(nums) - 1)):
                p1 += 1
                p2 = p1 + 1
            else:
                p2 += 1
        