public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;

        while(left <= right){
            while(!char.IsLetterOrDigit(s[left])){
                left++;
                if(left > right) return true;
            }
            while(!char.IsLetterOrDigit(s[right])){
                right--;
                if(left > right) return true;
            }

            if(char.ToUpper(s[left]) != char.ToUpper(s[right])) return false;

            left++;
            right--;
        }

        return true;
    }
}
