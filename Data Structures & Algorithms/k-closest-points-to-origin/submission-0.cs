public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double> maxHeap = new();

        foreach(var point in points) {
            double distance = Math.Sqrt((point[0] * point[0]) + (point[1] * point[1]));
            maxHeap.Enqueue(point, -distance);

            if (maxHeap.Count > k) {
                maxHeap.Dequeue();
            }
        }


        var result = new List<int[]>();

        while (maxHeap.Count > 0) {
            result.Add(maxHeap.Dequeue());
        }

        return result.ToArray();
    }
}
