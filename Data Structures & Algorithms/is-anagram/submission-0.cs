public class Solution {
    public bool IsAnagram(string s, string t) {
        var dict = new Dictionary<char, int>();

        foreach(var c in s){
            if(dict.ContainsKey(c)){
                dict[c] = dict[c] + 1;
            }
            else{
                dict.Add(c, 1);
            }
        }

        foreach(var c in t){
            if(dict.ContainsKey(c)){
                dict[c] = dict[c] - 1;
            }
            else{
                return false;
            }
        }

        var isAnagram = dict.Values.All(x => x==0);
        return isAnagram;
    }
}
