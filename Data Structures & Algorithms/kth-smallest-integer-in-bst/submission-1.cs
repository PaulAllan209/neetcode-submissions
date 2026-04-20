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
    private Stack<int> stack = new();

    public int KthSmallest(TreeNode root, int k) {
        dfs(root);

        int lenToPop = stack.Count - k;

        for (int i = 0; i < lenToPop; i++) {
            stack.Pop();
        }

        return stack.Pop();
    }
    private void dfs(TreeNode node) {
        if (node == null) return;

        // left, node, right
        if (node.left != null) dfs(node.left);
        stack.Push(node.val);
        if (node.right != null) dfs(node.right);

    }
}
