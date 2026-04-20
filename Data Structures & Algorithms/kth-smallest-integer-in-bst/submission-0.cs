/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    private SortedList<int, int> sorted = new();

    public int KthSmallest(TreeNode root, int k) {
        dfs(root);

        return sorted.Keys[k - 1];
    }
    private void dfs(TreeNode node) {
        if (node == null) return;

        sorted.Add(node.val, node.val);
        dfs(node.left);
        dfs(node.right);
    }
}
