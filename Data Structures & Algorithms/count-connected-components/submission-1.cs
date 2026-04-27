public class Solution {
    private Dictionary<int, List<int>> nodes = new();
    private HashSet<int> seen = new();
    private int res = 0;

    public int CountComponents(int n, int[][] edges) {
        for (int i = 0; i < n; i++) {
            nodes[i] = new List<int>();
        }

        for (int i = 0; i < edges.Length; i++) {
            var node1 = edges[i][0];
            var node2 = edges[i][1];

            nodes[node1].Add(node2);
            nodes[node2].Add(node1);
        }

        foreach (int key in nodes.Keys) {
            if (!seen.Contains(key)) {
                dfs(key);
                res++;
            }
        }

        return res;
    }

    private void dfs(int key) {
        seen.Add(key);

        foreach(int item in nodes[key]) {
            if (!seen.Contains(item)) {
                dfs(item);
            }
        }
    }
}
