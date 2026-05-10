public class MedianFinder {
    private PriorityQueue<int, int> small;
    private PriorityQueue<int, int> large;

    public MedianFinder() {
        small = new();
        large = new();
    }
    
    public void AddNum(int num) {
        if(large.Count > 0 && num > large.Peek()){
            large.Enqueue(num, num);
        }else{
            small.Enqueue(num, -num);
        }

        if(small.Count -1 >large.Count){
            var poped = small.Dequeue();
            large.Enqueue(poped, poped);
        }else if(small.Count +1 < large.Count){
            var poped = large.Dequeue();
            small.Enqueue(poped, -poped);
        }
    }
    
    public double FindMedian() {
        int n = small.Count + large.Count; 

        if(n%2 == 0){
            return (small.Peek()+large.Peek())/2.0;
        }
        
        return small.Count > large.Count? small.Peek(): large.Peek();
    }
}
