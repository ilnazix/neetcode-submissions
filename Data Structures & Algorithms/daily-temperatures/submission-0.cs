public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new();
        var result = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++){
            var t = temperatures[i];

            while(stack.Count > 0 && t > temperatures[stack.Peek()]){
                var pos = stack.Pop();
                result[pos] = i - pos; 
            }

            stack.Push(i);
        }

        return result;
    }
}
