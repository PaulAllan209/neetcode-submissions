public class Solution {
    private HashSet<int> visiting = new();
    private HashSet<int> done = new();

    private Dictionary<int, List<int>> preReq = new();
    private List<int> res = new();

    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        for (int i = 0; i < numCourses; i++) {
            preReq[i] = new List<int>();
        }

        for (int i = 0; i < prerequisites.Length; i++) {
            var req = prerequisites[i];
            preReq[req[0]].Add(req[1]);
        }

        foreach(int key in preReq.Keys) {
            if(!dfs(key)) return new int[] {};
        }

        return res.ToArray();
    }

    private bool dfs(int key) {
        if (done.Contains(key)) return true;
        if (visiting.Contains(key)) return false;

        visiting.Add(key);

        foreach (var req in preReq[key]) {
            if (!dfs(req)) return false;
        }

        visiting.Remove(key);
        done.Add(key);
        res.Add(key);

        return true;
    }
}
