public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> minHeap = new();

        foreach (int i in nums) {
            minHeap.Enqueue(i, i);
        }

        while(minHeap.Count > k) {
            minHeap.Dequeue();
        }

        return minHeap.Peek();
    }
}
