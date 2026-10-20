public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var stack = new Stack<int>();
        var n = heights.Length;
        
        var firstLessRight = Enumerable.Range(0, n).Select(x => n).ToArray();
        var firstLessLeft = Enumerable.Range(0, n).Select(x => -1).ToArray();

        for(int i = 0; i < n; i++){
            while(stack.Count > 0 && heights[stack.Peek()] > heights[i]){
                var index = stack.Pop();
                firstLessRight[index] = i;
            }

            stack.Push(i);
        }

        stack.Clear();

        for(int i = n - 1; i >= 0; i--){
            while(stack.Count > 0 && heights[stack.Peek()] > heights[i]){
                var index = stack.Pop();
                firstLessLeft[index] = i;
            }

            stack.Push(i);
        }

        var maxArea = 0;

        for(int j = 0; j < n; j++){
            var flrIndex = firstLessRight[j];
            var fllIndex = firstLessLeft[j];

            var surface = (flrIndex - fllIndex - 1) * heights[j]; 

            maxArea = Math.Max(maxArea, surface);
        }

        return maxArea;
    }
}
