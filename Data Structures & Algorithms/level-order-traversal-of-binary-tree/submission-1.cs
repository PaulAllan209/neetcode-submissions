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
        var q = new Queue<TreeNode>();
        var res = new List<List<int>>();
        q.Enqueue(root);

        while (q.Count > 0) {
            int qLen = q.Count;
            var addList = new List<int>();

            for (int i = 0; i < qLen; ++i) {
                var node = q.Dequeue();
                if (node != null) {
                    addList.Add(node.val);
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }

            if (addList.Count > 0) {
                res.Add(addList);
            }
        }

        return res;
    }
}
