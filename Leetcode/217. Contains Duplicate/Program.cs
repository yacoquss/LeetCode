namespace TestApp._217._Contains_Duplicate;


var sol = new Solution();
int[] nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];
Console.WriteLine(sol.ContainsDuplicate(nums));


public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var elementsCounts = nums
            .GroupBy(x => x)
            .Select(g => new { Element = g.Key, Count = g.Count() });

        foreach (var elementCount in elementsCounts
                     .Where(x=>x.Count>=2))
        {
            return true;
        }
        return false;
    }
}