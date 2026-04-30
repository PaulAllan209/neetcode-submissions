public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        int n = edges.Length;
        int[] parent = new int[n + 1];

        for (int i = 0; i < n; i++) {
            parent[i] = i;
        }

        foreach (var edge in edges) {
            var u = edge[0];
            var v = edge[1];

            if (Find(parent, u) == Find(parent, v)) {
                return edge;
            }

            Union(parent, u, v);
        }

        return Array.Empty<int>();
    }

    private void Union(int[] parent, int a, int b) {
        parent[Find(parent, a)] = Find(parent, b);
    }
    private int Find(int[] parent, int x) {
        if (parent[x] != x) {
            parent[x] = Find(parent, parent[x]);
        }

        return parent[x];
    }
}
