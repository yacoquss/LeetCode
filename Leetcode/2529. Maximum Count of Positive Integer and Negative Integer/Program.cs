namespace TestApp._2529._Maximum_Count_of_Positive_Integer_and_Negative_Integer;

var sol = new Solution();
int[] nums = [-3, -2, -1, 0, 0, 1, 2];
Console.WriteLine(sol.MaximumCount(nums));


public class Solution {
    public int MaximumCount(int[] nums) {
        var pos  = nums.Where(p => p > 0);
        var neg = nums.Where(p => p < 0);
        var maxcount = Math.Max(pos.Count(), neg.Count());
        return maxcount;
    }
}