namespace TestApp._3461._Check_If_Digits_Are_Equal_in_String_After_Operations_I;

public class Program
{
    
}

public class Solution {
    public bool HasSameDigits(string s) {
        while(s.Length > 2)
        {     
            var val = ""; 
            for(int i=0; i<s.Length-1; i++)
            {
                val = val + ((s[i] + s[i+1]) % 10);
            }
            s = val;
        }
        return s[0].Equals(s[1]) ? true : false;
    }
}