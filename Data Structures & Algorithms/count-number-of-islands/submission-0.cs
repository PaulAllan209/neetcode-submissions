public class Solution {
    private char[][] grid;
    private int ROW;
    private int COL;

    private int res = 0;

    public int NumIslands(char[][] grid) {
        this.grid = grid;
        ROW = grid.Length;
        COL = grid[0].Length;

        for (int r = 0; r < ROW; r++) {
            for(int c = 0; c < COL; c++) {
                if (this.grid[r][c] != '0') {
                    dfs(r, c);
                    res++;
                }
            }
        }

        return res;
    }

    private void dfs(int row, int col) {
        if (row < 0 || 
            row >= ROW ||
            col < 0 ||
            col >= COL) return;

        if (grid[row][col] == '0') return;

        grid[row][col] = '0';

        // top
        dfs(row - 1, col);

        // bottom
        dfs(row + 1, col);
        
        // left
        dfs(row, col - 1);

        // right
        dfs(row, col + 1);
    }
}
