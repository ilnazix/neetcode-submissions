public class Solution {
    public int MaxArea(int[] heights) {
        var l = 0;
        var r = heights.Length - 1;
        var maxArea = 0;

        while(l < r){
            var currentArea = Math.Min(heights[l], heights[r]) * (r - l);
            maxArea = Math.Max(maxArea, currentArea);

            if(heights[l] < heights[r]){
                l++;
            }
            else{
                r--;
            }
        }

        return maxArea;
    }
}
