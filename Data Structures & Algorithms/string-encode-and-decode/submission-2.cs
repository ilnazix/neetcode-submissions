public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        var delimetr = "#";

        foreach(var s in strs){
            sb.Append(s.Length);
            sb.Append(delimetr);

            sb.Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var count = new StringBuilder();
        var result = new List<string>();

        int i = 0;
        while(i < s.Length){
            if(char.IsDigit(s[i])){
                count.Append(s[i]);
                i++;
            }
            else{
                var length = int.Parse(count.ToString());

                var str = s.Substring(++i, length);

                i += length;

                result.Add(str);
                count.Clear();
            }
        }

        return result;
   }
}
