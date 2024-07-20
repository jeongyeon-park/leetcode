public class RecentCounter {

    Queue<int> queue;
    public RecentCounter() {
        queue = new Queue<int>();
    }
    
    public int Ping(int t) {
        int startRange = t - 3000;
        int endRange = t;
        queue.Enqueue(t);
        int cnt = 0;
        foreach(int i in queue)
        {
            if(i >= startRange && i <= endRange) cnt++;
        }
        return cnt;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */