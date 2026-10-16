public class Solution {
    public bool IsValid(string s) {
        var complement = new Dictionary<char, char>{
            {']', '['}, 
            {'}', '{'}, 
            {')', '('}};

        var stack = new Stack<char>();

        foreach(var c in s){
            if(c == '[' || c == '{' || c == '('){
                stack.Push(c);
            }
            else{
                if(!stack.TryPop(out var l) || l != complement[c]) return false;
            }
        }

        return stack.Count == 0;
    }
}
