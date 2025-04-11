namespace TestApp._2843._Count_Symmetric_Integers;

public class Program
{
    
}

public class Solution {
    public int CountSymmetricIntegers(int low, int high) => 
        Enumerable.Range(low, (high - low) + 1).
            Select(i => i.ToString().ToCharArray()).
            Where(m => m.Length % 2 == 0 &&
                       m.Take(m.Length / 2).Sum(m => char.GetNumericValue(m)) ==
                       m.Skip(m.Length / 2).Sum(m => char.GetNumericValue(m))).
            Count();
}