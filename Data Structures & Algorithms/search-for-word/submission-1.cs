public class Solution {
    private bool res = false;
    private bool exit = false;

    private HashSet<(int, int)> seen = new();
    public bool Exist(char[][] board, string word) {

        for (int r = 0; r < board.Length; r++) {
            for (int c = 0; c < board[r].Length; c++) {
                Backtrack(board, r, c, 0, word);
                if (res) return true;
            }
        }

        return res;
    }

    private void Backtrack(char[][] board, int row, int col, int charI, string word) {
        if ((row < 0) || (col < 0)) return;
        if (board[0].Length <= col) return;
        if (board.Length <= row) return;
        if (word.Length <= charI) return;
        if (seen.Contains((row, col))) return;
        if (word[charI] != board[row][col]) return;

        seen.Add((row, col));

        if ((charI + 1) == word.Length)
        {
            res = true;
            seen.Remove((row, col));
            return;
        }

        // Top
        Backtrack(board, row - 1, col, charI + 1, word);

        // Right
        Backtrack(board, row, col + 1, charI + 1, word);

        // Bottom
        Backtrack(board, row + 1, col, charI + 1, word);

        // Left
        Backtrack(board, row, col - 1, charI + 1, word);

        seen.Remove((row, col));
    }
}
