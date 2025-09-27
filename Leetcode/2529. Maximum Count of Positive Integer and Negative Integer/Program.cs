namespace TestApp._2529._Maximum_Count_of_Positive_Integer_and_Negative_Integer;


public class Solution {
    public int MaximumCount(int[] nums) {
        var pos  = nums.Where(p => p > 0);
        var neg = nums.Where(p => p < 0);
        var maxcount = Math.Max(pos.Count(), neg.Count());
        return maxcount;
    }
}