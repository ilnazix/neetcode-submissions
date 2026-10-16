public class Solution {
    public bool IsValid(string s) {
        var complement = new Dictionary<char, char>{
            {']', '['}, 
            {'}', '{'}, 
            {')', '('}};

        var stack = new Stack<char>();

        foreach(var c in s){
            if(complement.TryGetValue(c, out var open)){
                if(!stack.TryPop(out var top) || top != open) return false;
            }
            else{
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}
