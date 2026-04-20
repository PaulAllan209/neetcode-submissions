public class Solution {
    int ROW;
    int COL;
    int[][] grid;

    public int MaxAreaOfIsland(int[][] grid) {
        ROW = grid.Length;
        COL = grid[0].Length;
        this.grid = grid;

        int res = 0;

        for (int r = 0; r < ROW; r++) {
            for (int c = 0; c < COL; c++) {
                if (this.grid[r][c] == 1) {
                    res = Math.Max(res, dfs(r, c));
                }
            }
        }

        return res;
    }

    private int dfs(int row, int col) {
        if (
            row < 0 ||
            row >= ROW ||
            col < 0 ||
            col >= COL
        ) return 0;

        if (grid[row][col] == 0) return 0;

        grid[row][col] = 0;

        return dfs(row - 1, col) + dfs(row + 1, col) + dfs(row, col + 1) + dfs(row, col - 1) + 1;
    }
}
