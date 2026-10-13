public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = nums.ToHashSet();
        var maxLength = 0;
        foreach(var num in set){
            if(set.Contains(num - 1)) continue;
            var length = 1;
            var n = num;

            while(set.Contains(n + 1)){
                length++;
                n++;
            } 

            maxLength = Math.Max(maxLength, length);
        }

        return maxLength;
    }
}
