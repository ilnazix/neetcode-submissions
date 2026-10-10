public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>(); 
        
        foreach(var n in nums){
            if(dict.ContainsKey(n)){
                dict[n] += 1;
            }
            else{
                dict.Add(n, 1);
            }
        }

        var queue = new PriorityQueue<int, int>();

        foreach(var (key, value) in dict){
            queue.Enqueue(key, value);

            if(queue.Count > k){
                queue.Dequeue();
            }
        }

        var result = new int[k];

        for(int i = 0; i < k; i++){
            result[i] = queue.Dequeue();
        }

        return result;
    }
}
