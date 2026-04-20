public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        PriorityQueue<int, int> maxHeap = new();
        Queue<(int, int)> q = new();
        Dictionary<char, int> hash = new();
        int counter = 0;

        foreach (char c in tasks) {
            if (hash.TryGetValue(c, out var value)) {
                ++hash[c];
            }
            else {
                hash.Add(c, 1);
            }
        }

        foreach (int i in hash.Values) {
            maxHeap.Enqueue(i, -i);
        }

        while (maxHeap.Count > 0 || q.Count > 0) {
            if (q.Count > 0 && q.Peek().Item2 <= counter) {
                var queuePop = q.Dequeue();
                maxHeap.Enqueue(queuePop.Item1, -queuePop.Item1);
            }

            if (maxHeap.Count > 0) {
                var pop = maxHeap.Dequeue() - 1;

                if (pop > 0) {
                    q.Enqueue((pop, counter + n + 1));
                }
            }
            
            counter++;
        }

        return counter;
    }
}
