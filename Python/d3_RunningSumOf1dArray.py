class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        res_list = []
        sum = 0;
        for num in nums:
            sum = sum + num;
            res_list.insert(len(res_list), sum)
        return res_list
