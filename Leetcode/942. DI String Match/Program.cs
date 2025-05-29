namespace TestApp._942._DI_String_Match;

public class Program
{
    
}

public class Solution {
    public int[] DiStringMatch(string s) {
        int i = 0;
        int j = s.Length;
        int[] res = new int[j + 1];
        for(int k = 0; k < s.Length; k++){
            if(s[k] == 'I') res[k] = i++;
            else res[k] = j--;
        }
        res[res.Length - 1] = i;
        return res;
    }
}