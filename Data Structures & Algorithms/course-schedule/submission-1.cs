public class Solution {
    private Dictionary<int, List<int>> preReqs = new();
    private HashSet<int> seen = new();

    public bool CanFinish(int numCourses, int[][] prerequisites) {
        for (int i = 0; i < prerequisites.Length; i++) {
            int[] courses = prerequisites[i];

            if (preReqs.ContainsKey(courses[0])) {
                preReqs[courses[0]].Add(courses[1]);
            }
            else {
                preReqs[courses[0]] = new List<int> {courses[1]};
            }
        }

        foreach(int key in preReqs.Keys) {
            if (!dfs(key)) return false;
        }

        return true;
    }

    private bool dfs(int key) {
        if (!preReqs.ContainsKey(key)) return true;
        if (!preReqs[key].Any()) return true;
        if (seen.Contains(key)) return false;

        seen.Add(key);
        foreach (var item in preReqs[key]) {
            if (!dfs(item)) return false;
        }
        preReqs[key] = new();

        return true;
    }
}
