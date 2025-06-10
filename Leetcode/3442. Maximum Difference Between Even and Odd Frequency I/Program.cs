namespace TestApp._3442._Maximum_Difference_Between_Even_and_Odd_Frequency_I;

public class Program
{
    
}
public class Solution {
    public int MaxDifference(string s) {
        
        var freq = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        
        var oddFreqs = freq.Values.Where(f => f % 2 == 1).ToList();
        var evenFreqs = freq.Values.Where(f => f % 2 == 0).ToList();
        
        if (oddFreqs.Count == 0 || evenFreqs.Count == 0)
            return -1;
        
        int maxOdd = oddFreqs.Max();
        int minEven = evenFreqs.Min();
        
        return maxOdd - minEven;
    }
}