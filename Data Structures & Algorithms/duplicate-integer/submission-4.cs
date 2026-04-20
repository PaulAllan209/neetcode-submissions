public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> keys = new Dictionary<int, int>();


        foreach(int num in nums){
            if(keys.ContainsKey(num)){
                return true;
            }
            else{
                keys[num] = 0;
            }
        }
        return false;
    }
}