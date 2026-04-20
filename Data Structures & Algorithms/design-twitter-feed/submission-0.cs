public class Twitter {
    private Dictionary<int, HashSet<int>> following = new();
    private Dictionary<int, List<(int count, int tweetId)>> tweets = new();
    private int count = 0;

    public Twitter() {
        
    }
    
    public void PostTweet(int userId, int tweetId) {
        count++;
        if (tweets.TryGetValue(userId, out var listTweets)) {
            listTweets.Add((count, tweetId));
        }
        else {
            tweets[userId] = new List<(int count, int tweetId)> { (count, tweetId) };
        }
    }
    
    public List<int> GetNewsFeed(int userId) {
        PriorityQueue<int, int> maxHeap = new();
        HashSet<int> currFollowing = new();
        currFollowing.Add(userId);

        if(following.TryGetValue(userId, out var followingSet)) {
            foreach (var item in followingSet) {
                currFollowing.Add(item);
            }
        }

        foreach(var author in currFollowing) {
            if (tweets.TryGetValue(author, out var listTweets)) {
                foreach (var t in listTweets) {
                    maxHeap.Enqueue(t.tweetId, -t.count);
                }
            }
        }

        List<int> res = new();

        for (int i = 0; i < 10 && maxHeap.Count > 0; i++) {
            res.Add(maxHeap.Dequeue());
        }

        return res;
    }
    
    public void Follow(int followerId, int followeeId) {
        if (following.TryGetValue(followerId, out var followingIds)) {
            followingIds.Add(followeeId);
        }
        else {
            following[followerId] = new HashSet<int> { followeeId };
        }
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if (following.TryGetValue(followerId, out var followingIds)) {
            followingIds.Remove(followeeId);
        }
    }
}
