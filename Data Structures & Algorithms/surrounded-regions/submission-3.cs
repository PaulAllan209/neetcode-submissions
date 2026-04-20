public class Solution {
    // private HashSet<(int, int)> cannotFlip = new();
    private int ROW;
    private int COL;

    public void Solve(char[][] board) {
        ROW = board.Length;
        COL = board[0].Length;
        
        for (int r = 0; r < ROW; r++) {
            dfs(r, 0, board);
            dfs(r, COL - 1, board);
        }

        for (int c = 0; c < COL; c++) {
            dfs(0, c, board);
            dfs(ROW - 1, c, board);
        }

        for (int r = 0; r < ROW; r++) {
            for (int c = 0; c < COL; c++) {
                if (board[r][c] == 'T') {
                    board[r][c] = 'O';
                }
                else {
                    board[r][c] = 'X';
                }
            }
        }
    }

    private void dfs(int r, int c, char[][] board) {
        if (
            r < 0 ||
            c < 0 ||
            r >= ROW ||
            c >= COL ||
            board[r][c] == 'X' ||
            board[r][c] == 'T'
        ) return;

        board[r][c] = 'T';

        dfs(r - 1, c, board);
        dfs(r + 1, c, board);
        dfs(r, c - 1, board);
        dfs(r, c + 1, board);
    }
}
