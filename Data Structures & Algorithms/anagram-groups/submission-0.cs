public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        var musk = new short[26];

        foreach(var s in strs){
            foreach(var c in s){
                musk[c - 'a'] += 1;
            }

            var key = new string(musk.Select(c => (char)c).ToArray());

            if(!dict.ContainsKey(key)){
                dict.Add(key, new List<string>());
            }

            dict[key].Add(s);

            for(int i = 0; i < 26 ;i++){
                musk[i] = 0;
            }
        }

        return dict.Values.ToList();
    }
}
