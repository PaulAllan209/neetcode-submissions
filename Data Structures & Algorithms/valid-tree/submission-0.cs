public class Solution {
    private HashSet<int> seen = new();
    private Dictionary<int, List<int>> nodes = new();

    public bool ValidTree(int n, int[][] edges) {
        if (edges.Length != (n-1)) return false;

        for(int i = 0; i < n; i++) {
            nodes[i] = new List<int>();
        }

        for (int i = 0; i < edges.Length; i++) {
            var edge = edges[i];
            var edge1 = edge[0];
            var edge2 = edge[1];

            nodes[edge1].Add(edge2);
            nodes[edge2].Add(edge1);
        }

        if(!dfs(0, -1)) return false;

        return seen.Count == n;
    }

    private bool dfs(int key, int parentNode) {
        seen.Add(key);

        foreach(int item in nodes[key]) {
            if (item == parentNode) continue;
            if (seen.Contains(item)) return false;

            if(!dfs(item, key)) return false;
        }

        return true;
    }
}
