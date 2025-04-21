namespace TestApp._3498._Reverse_Degree_of_a_String;


public class Program
{
    
}

public class Solution
{
    public int ReverseDegree(string s)
    {
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            
            if (c >= 'a' && c <= 'z')
            {
                
                int reverseAlphabetPosition = 26 - (c - 'a');
                
                int stringPosition = i + 1;
                sum += reverseAlphabetPosition * stringPosition;
            }
        }
        return sum;
    }
}