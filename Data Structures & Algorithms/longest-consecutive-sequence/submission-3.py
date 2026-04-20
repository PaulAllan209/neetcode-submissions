class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        nums_seq = []

        for num in nums:
            if((num-1) not in nums):
                seq_to_append = 1
                curr_num = num
                while(True):
                    if((curr_num + 1) in nums):
                        curr_num += 1
                        seq_to_append += 1
                    else:
                        nums_seq.append(seq_to_append)
                        break
            else:
                continue


        return max(nums_seq, default=0)