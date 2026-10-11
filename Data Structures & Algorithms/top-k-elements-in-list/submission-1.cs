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

        var buckets = new List<int>[nums.Length + 1];

        foreach(var (key, value) in dict){
            if(buckets[value] is null){
                buckets[value] = new List<int>();
            }

            buckets[value].Add(key);
        }

        var result = new int[k];
        var idx = 0;

        for(var f = buckets.Length - 1; f >= 0 && idx < k; f--){
            if(buckets[f] is null) continue;

            foreach(var v in buckets[f]){
                result[idx++] = v;
            }
        }

        return result;
    }
}
