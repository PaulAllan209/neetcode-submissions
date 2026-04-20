public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l1 = 0;
        int r1 = matrix.Length - 1;
        int p1 = (r1 + l1) / 2;
        int l2 = 0;
        int r2 = 0;
        int p2 = 0;

        while (l1 <= r1) {
            if (matrix[p1][0] > target) {
                r1 = p1 - 1;
            }
            else if (matrix[p1][matrix[p1].Length - 1] < target) {
                l1 = p1 + 1;
            }
            else {
                break;
            }
            p1 = (r1 + l1) / 2;
        }

        if(!(l1 <= r1)) {
            return false;
        }

        l2 = 0;
        r2 = matrix[p1].Length - 1;
        p2 = (r2 + l2) / 2;

        while (l2 <= r2) {
            if (matrix[p1][p2] > target) {
                r2 = p2 - 1;
            }
            else if (matrix[p1][p2] < target) {
                l2 = p2 + 1;
            }
            else {
                return true;
            }
            p2 = (r2 + l2) / 2;
        }

        return false;
        
    }
}
