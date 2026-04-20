public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l1 = 0;
        int r1 = matrix.Length - 1;
        int p1 = (l1 + r1)/2;

        while (l1 <= r1) {
            if (matrix[p1][^1] >= target && matrix[p1][0] <= target) {
                break;
            }
            else if (matrix[l1][^1] < target) {
                l1 = p1 + 1;
            }
            else if (matrix[r1][0] > target) {
                r1 = p1 - 1;
            }
            p1 = (l1 + r1)/2;
        }

        if (!(matrix[p1][^1] >= target && matrix[p1][0] <= target)) {
            return false;
        }

        int[] currList = matrix[p1];

        int l2 = 0;
        int r2 = currList.Length - 1;
        int p2 = (l2 + r2)/2;

        while (l2 <= r2) {
            if (currList[p2] == target) {
                return true;
            }
            else if (currList[l2] < target) {
                l2 = p2 + 1;
            }
            else if (currList[r2] > target) {
                r2 = p2 - 1;
            }
            p2 = (l2 + r2)/2;
        }

        return false;
    }
}
