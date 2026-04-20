public class Solution {

    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> maxHeap = new();

        foreach(int stone in stones) {
            maxHeap.Enqueue(stone, -stone);
        }

        while (maxHeap.Count > 1) {
            int s1 = maxHeap.Dequeue();
            int s2 = maxHeap.Dequeue();

            if (s1 > s2) {
                int resulting = s1 - s2;
                maxHeap.Enqueue(resulting, -resulting);
            }
        }

        if (maxHeap.Count == 0 ) return 0;

        return maxHeap.Peek();
    }
}
