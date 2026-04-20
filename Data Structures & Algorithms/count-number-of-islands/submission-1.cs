public class Solution {
    int ROW;
    int COL;
    char[][] grid;
    public int NumIslands(char[][] grid) {
        ROW = grid.Length;
        COL = grid[0].Length;
        this.grid = grid;
        int res = 0;

        for (int r = 0; r < ROW; r++) {
            for (int c = 0; c < COL; c++) {
                if (this.grid[r][c] == '1') {
                    dfs(r, c);
                    res++;
                }
            }
        }

        return res;
    }

    private void dfs(int row, int col) {
        if (
            row < 0 ||
            row >= ROW ||
            col < 0 ||
            col >= COL
        ) return;

        if (grid[row][col] == '0') return;

        grid[row][col] = '0';

        // top
        dfs(row - 1, col);

        // right
        dfs(row, col + 1);

        // bottom
        dfs(row + 1, col);

        // left
        dfs(row, col - 1);
    }
}
