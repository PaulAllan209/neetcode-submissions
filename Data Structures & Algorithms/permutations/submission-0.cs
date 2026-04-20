public class Solution {
    private List<List<int>> res = new();
    private int len = 0;

    public List<List<int>> Permute(int[] nums) {
        len = nums.Length;

        Back(nums.ToList(), new());

        return res;
    }

    private void Back(List<int> items, List<int> curr) {
        if (curr.Count >= len) {
            res.Add(curr.ToList());
            return;
        }

        for(int i = 0; i < items.Count; i++) {
            var itemsCopy = items.ToList();
            var currCopy = curr.ToList();
            int toAdd = itemsCopy[i];
            currCopy.Add(toAdd);
            itemsCopy.Remove(toAdd);

            Back(itemsCopy, currCopy);
        }
    }
}
