public class Twitter {
    private int _count;
    private Dictionary<int, HashSet<int>> _followers;
    private Dictionary<int, List<(int count, int tweetId)>> _posts;

    public Twitter() {
        _followers = new();
        _posts = new();
        _count = 0;
    }

    public void PostTweet(int userId, int tweetId) {
        _count--;

        if (!_posts.ContainsKey(userId)) {
            _posts[userId] = new();
        }

        _posts[userId].Add((_count, tweetId));
    }

    public List<int> GetNewsFeed(int userId) {
        var result = new List<int>();
        var heap = new PriorityQueue<int[], int>();  // 0-followeeId, int i, postId
        
        var followees = new HashSet<int> { userId };
        if (_followers.TryGetValue(userId, out var following))
            followees.UnionWith(following);

        foreach (var f in followees) {
            if (_posts.ContainsKey(f)) {
                int i = _posts[f].Count - 1;
                var post = _posts[f][i];
                heap.Enqueue(new int[] { f, i, post.tweetId }, post.count);
            }
        }

        while (heap.Count > 0 && result.Count < 10) {
            var el = heap.Dequeue();
            result.Add(el[2]);

            int i = el[1] - 1;
            if (i >= 0) {
                int f = el[0];
                var post = _posts[f][i];
                heap.Enqueue(new int[] { f, i, post.tweetId }, post.count);
            }
        }
        return result;
    }

    public void Follow(int followerId, int followeeId) {
        if (!_followers.ContainsKey(followerId)) {
            _followers[followerId] = new();
        }

        _followers[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId) {
        if (_followers.ContainsKey(followerId)) {
            _followers[followerId].Remove(followeeId);
        }
    }
}
