public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int index1 = 0;
        int index2 = numbers.Length - 1;
        int lengthNums = numbers.Length;

        for(int i = 0; i < lengthNums; i++) {
            if((numbers[index2] + numbers[index1]) > target) {
                index2--;
            }
            else if ((numbers[index2] + numbers[index1]) < target) {
                index1++;
            }
            else {
                
                return new int[] {index1 + 1, index2 + 1};
            }
        }

        return new int[] {index1 + 1, index2 + 1};
    }
}
