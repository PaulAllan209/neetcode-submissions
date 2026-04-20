public class Solution {
    public int LastStoneWeight(int[] stones) {
        if (stones.Length == 1) return stones[0];

        PriorityQueue<int, int> minHeap = new();

        foreach(int i in stones) {
            minHeap.Enqueue(-i, -i);
        }

        while(minHeap.Count > 1) {
            int val1 = minHeap.Dequeue();
            int val2 = minHeap.Dequeue();

            if (val1 < val2) minHeap.Enqueue(val1 - val2, val1 - val2);
        }

        if (minHeap.Count == 0) return 0;

        return Math.Abs(minHeap.Peek());
    }
}
