public class KthLargest {
    private PriorityQueue<int, int> maxHeap = new();
    private int kLen = 0;

    public KthLargest(int k, int[] nums) {
        foreach(int i in nums) {
            maxHeap.Enqueue(i, i);
        }

        while (maxHeap.Count > k) {
            maxHeap.Dequeue();
        }

        kLen = k;
    }
    
    public int Add(int val) {
        maxHeap.Enqueue(val, val);

        while (maxHeap.Count > kLen) {
            maxHeap.Dequeue();
        }

        return maxHeap.Peek();
    }
}
