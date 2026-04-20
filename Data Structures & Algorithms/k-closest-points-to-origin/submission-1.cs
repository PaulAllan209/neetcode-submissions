public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double> minHeap = new();

        foreach(int[] p in points) {
            int x = p[0];
            int y = p[1];

            minHeap.Enqueue(p, Math.Sqrt((x * x) + (y * y)));
        }

        List<int[]> res = new();

        for (int i = 0; i < k; i++) {
            res.Add(minHeap.Dequeue());
        }

        return res.ToArray();
    }
}
