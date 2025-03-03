var sol = new Solution();
int[] nums = [4,1,2,1,2];
Console.WriteLine(sol.SingleNumber(nums));


public class Solution
{
    public int SingleNumber(int[] nums)
    {
        var elementCounts = nums
            .GroupBy(x => x)
            .Select(g => new { Element = g.Key, Count = g.Count() });


        foreach (var item in elementCounts
                     .Where(x => x.Count == 1))
        {
            return item.Element;
        }
        return nums[0];
    }
}