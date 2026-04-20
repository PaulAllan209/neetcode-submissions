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
    public List<List<int>> LevelOrder(TreeNode root) {
        var res = new List<List<int>>();

        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0) {
            int qLen = q.Count;

            var level = new List<int>();
            for (; qLen != 0; --qLen) {
                var node = q.Dequeue();

                if (node != null) {
                    level.Add(node.val);
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }

            if (level.Count > 0) {
                res.Add(level);
            }
        }

        return res;
    }
}
