public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<List<int>>();

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > 0) break;

            if(i > 0 && nums[i] == nums[i - 1]) continue;

            
                var left = i + 1;
                var right = nums.Length - 1;

                while(left < right){
                    var sum = nums[i] + nums[left] + nums[right];

                    if(sum < 0){
                        left++;
                    } 
                    else if(sum > 0){
                        right--;
                    }
                    else{
                        result.Add(new List<int>(){nums[i], nums[left], nums[right]});
                        left++;

                        while(left < right && nums[left] == nums[left - 1]) left++;
                    }
                }
        }

        return result;
    }
}
