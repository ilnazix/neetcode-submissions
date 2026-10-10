public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            var n = nums[i];
            var compliment = target - n;
            if(dict.ContainsKey(compliment)){
                return new int[] {dict[compliment], i};
            }
            else{
                dict.Add(n, i);
            }
        }

        return new int[] {0, 0};
    }
}
