public class Solution {
    public int LeastInterval(char[] tasks, int n) {
       PriorityQueue<int, int> maxHeap = new();
       Queue<(int, int)> q = new();
       Dictionary<char, int> dict = new();
       int counter = 0; 

        foreach(char c in tasks) {
            if (dict.ContainsKey(c)) {
                dict[c] += 1;
            }
            else {
                dict[c] = 1;
            }
        }

        foreach(var val in dict.Values) {
            maxHeap.Enqueue(val, -val);
        }

        while (maxHeap.Count != 0 || q.Count != 0) {
            if (q.Count != 0 && q.Peek().Item2 == counter) {
                var item = q.Dequeue().Item1;
                maxHeap.Enqueue(item, -item);
            }

            if (maxHeap.Count != 0) {
                var item = maxHeap.Dequeue();
                item -= 1;

                if (item > 0) {
                    q.Enqueue((item, counter + n + 1));
                }
            }

            counter++;
        }

        return counter;
    }
}
