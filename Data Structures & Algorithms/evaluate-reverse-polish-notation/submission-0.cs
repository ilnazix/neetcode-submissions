public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        var operations = new Dictionary<string, Func<int, int, int>>(){
            {"+", (x, y) => x + y},
            {"-", (x, y) => x - y},
            {"*", (x, y) => x * y},
            {"/", (x, y) => x / y},
        };

        foreach(var token in tokens){
            if(int.TryParse(token, out var number)){
                stack.Push(number);
                continue;
            }

            var second = stack.Pop();
            var first = stack.Pop();

            stack.Push(operations[token](first, second));
        }

        return stack.Pop();
    }
}
