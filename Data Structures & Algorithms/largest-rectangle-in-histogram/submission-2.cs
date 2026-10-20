public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var n = heights.Length;
        var stack = new Stack<int>();

        var firstLessRight = Enumerable.Range(0, n).Select(x => n - x).ToArray();
        var firstLessLeft = Enumerable.Range(0, n).Select(x => x + 1).ToArray();
        
        for(int i = 0; i < n; i++){
            while(stack.Count > 0 && heights[i] < heights[stack.Peek()]){
                var index = stack.Pop();
                var distance = i - index;
                firstLessRight[index] = distance; 
            }

            stack.Push(i);
        }

        stack.Clear();

        for(int i = n - 1; i >= 0; i--){
            while(stack.Count > 0 && heights[i] < heights[stack.Peek()]){
                var index = stack.Pop();
                var distance = index - i;
                firstLessLeft[index] = distance; 
            }

            stack.Push(i);
        }

        var maxArea = 0;
        for(int j = 0; j < n; j++){
            var height = heights[j];
            var leftRectWidthArea = firstLessLeft[j] * height;
            var rightRectWidthArea = firstLessRight[j] * height;

            var area = leftRectWidthArea + rightRectWidthArea - height * 1;
            maxArea = Math.Max(area, maxArea);
        }

        return maxArea;
    }
}
