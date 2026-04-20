class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        nums_seq = []
        longest = 0

        for num in nums:
            if((num-1) not in nums):
                seq_length= 1
                curr_num = num
                while((curr_num+1) in nums):
                    curr_num += 1
                    seq_length += 1
                
                longest = max(longest, seq_length)
            else:
                continue


        return longest