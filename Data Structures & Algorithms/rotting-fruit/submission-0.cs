public class Solution {
    private Queue<(int, int, int)> q = new();
    private int freshCount = 0;
    private int ROW;
    private int COL;
    private int res = 0;

    public int OrangesRotting(int[][] grid) {
        ROW = grid.Length;
        COL = grid[0].Length;

        for (int r = 0; r < ROW; r++) {
            for (int c = 0; c < COL; c++) {
                if (grid[r][c] == 1) {
                    freshCount++;
                }
                else if (grid[r][c] == 2) {
                    q.Enqueue((r, c, 0));
                }
            }
        }

        while (q.Count > 0) {
            var popped = q.Dequeue();

            // top
            if ((popped.Item1 - 1) >= 0 && (grid[popped.Item1 - 1][popped.Item2] == 1)) {
                grid[popped.Item1 - 1][popped.Item2] = 2;
                freshCount--;

                q.Enqueue((popped.Item1-1, popped.Item2, popped.Item3+1));
            }

            // bottom
            if ((popped.Item1 + 1) < ROW && (grid[popped.Item1 + 1][popped.Item2] == 1)) {
                grid[popped.Item1 + 1][popped.Item2] = 2;
                freshCount--;

                q.Enqueue((popped.Item1+1, popped.Item2, popped.Item3+1));
            }

            // left
            if ((popped.Item2 - 1) >= 0 && (grid[popped.Item1][popped.Item2 - 1] == 1)) {
                grid[popped.Item1][popped.Item2 - 1] = 2;
                freshCount--;

                q.Enqueue((popped.Item1, popped.Item2 - 1, popped.Item3+1));
            }

            // right
            if ((popped.Item2 + 1) < COL && (grid[popped.Item1][popped.Item2 + 1] == 1)) {
                grid[popped.Item1][popped.Item2 + 1] = 2;
                freshCount--;

                q.Enqueue((popped.Item1, popped.Item2 + 1, popped.Item3+1));
            }

            res = Math.Max(res, popped.Item3);
        }

        if (freshCount > 0) return -1;
    
        return res;
    }
}
