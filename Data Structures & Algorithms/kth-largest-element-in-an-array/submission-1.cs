public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> maxHeap = new();

        foreach(int i in nums) {
            maxHeap.Enqueue(i, i);
            
            if (maxHeap.Count > k) {
                maxHeap.Dequeue();
            }
        }

        return maxHeap.Peek();
    }
}
