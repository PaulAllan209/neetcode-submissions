public class Solution {
    public List<List<int>> Subsets(int[] nums) {
      int n = nums.Length;
      List<List<int>> res = new();
      List<int> sol = new();  

      Dfs(nums, 0, sol, res);
      
      return res;
    }

    private void Dfs(int[] nums, int i , List<int> sol, List<List<int>> res) {
        if (i >= nums.Length) {
            res.Add(new List<int>(sol));
            return;
        }


        Dfs(nums, i + 1, sol, res);

        sol.Add(nums[i]);
        Dfs(nums, i + 1, sol, res);
        sol.RemoveAt(sol.Count - 1);
    }
}
