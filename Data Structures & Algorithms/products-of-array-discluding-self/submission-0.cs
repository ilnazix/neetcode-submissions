public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefix = new int[nums.Length];
        var suffix = new int[nums.Length];
        prefix[0] = 1;
        suffix[nums.Length - 1] = 1;

        for(int i = 1; i < nums.Length; i++){
            prefix[i] = nums[i - 1] * prefix[i - 1];
        }

        for(int j = nums.Length - 2; j >= 0; j--){
            suffix[j] = suffix[j + 1] * nums[j + 1];
        }

        for(int i = 0; i < nums.Length; i++){
            prefix[i] *= suffix[i];
        }

        return prefix;
    }
}
