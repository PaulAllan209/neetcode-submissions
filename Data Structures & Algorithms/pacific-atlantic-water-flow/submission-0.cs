public class Solution {
    private int ROW;
    private int COL;
    private HashSet<(int, int)> pacVisit = new();
    private HashSet<(int, int)> atlVisit = new();
    private int[][] heights;
    private List<List<int>> res = new();

    public List<List<int>> PacificAtlantic(int[][] heights) {
        this.heights = heights;
        ROW = heights.Length;
        COL = heights[0].Length;

        for (int c = 0; c < COL; c++) {
            dfs(0, c, pacVisit, heights[0][c]);
            dfs(ROW - 1, c, atlVisit, heights[ROW-1][c]);
        }

        for (int r = 0; r < ROW; r++) {
            dfs(r, 0, pacVisit, heights[r][0]);
            dfs(r, COL - 1, atlVisit, heights[r][COL-1]);
        }

        for (int r = 0; r < ROW; r++) {
            for (int c = 0; c < COL; c++) {
                if (pacVisit.Contains((r, c)) && atlVisit.Contains((r, c))) {
                    res.Add(new List<int>() {r, c});
                }
            }
        }

        return res;
    }

    private void dfs(int r, int c, HashSet<(int, int)> visit, int lastHeight) {
        if (
            r < 0 ||
            c < 0 ||
            r >= ROW ||
            c >= COL ||
            visit.Contains((r, c)) ||
            heights[r][c] < lastHeight
        ) return;

        visit.Add((r, c));

        dfs(r - 1, c, visit, heights[r][c]);
        dfs(r + 1, c, visit, heights[r][c]);
        dfs(r, c - 1, visit, heights[r][c]);
        dfs(r, c + 1, visit, heights[r][c]);
    }
}
