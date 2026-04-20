public class Solution {
    private int ROW;
    private int COL;

    public void islandsAndTreasure(int[][] grid) {
        ROW = grid.Length;
        COL = grid[0].Length;

        for(int r = 0; r < ROW; r++) {
            for (int c = 0; c < COL; c++) {
                if (grid[r][c] == 0) {
                    // Up
                    dfs(grid, 1, r - 1, c);

                    // down
                    dfs(grid, 1, r + 1, c);

                    // right
                    dfs(grid, 1, r, c + 1);

                    // left
                    dfs(grid, 1, r, c - 1);
                }
            }
        }
    }

    private void dfs(int[][] grid, int count, int r, int c) {
        if (
            r < 0 ||
            r >= ROW ||
            c < 0 ||
            c >= COL ||
            grid[r][c] == -1 ||
            grid[r][c] == 0 ||
            grid[r][c] < count
        ) return;

        grid[r][c] = Math.Min(grid[r][c], count);

        // Up
        dfs(grid, count + 1, r - 1, c);

        // down
        dfs(grid, count + 1, r + 1, c);

        // right
        dfs(grid, count + 1, r, c + 1);

        // left
        dfs(grid, count + 1, r, c - 1);
    }
}
