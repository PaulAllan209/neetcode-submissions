public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> maxHeap = new();

        foreach(int i in nums) {
            maxHeap.Enqueue(i, -i);
        }

        while (k != 1) {
            maxHeap.Dequeue();
            k--;
        }

        return maxHeap.Dequeue();
    }
}
