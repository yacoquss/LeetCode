using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums);
        var n = nums.Length;
        var result = new List<IList<int>>();

        var quads = from a in Enumerable.Range(0, n - 3)
            from b in Enumerable.Range(a + 1, n - a - 3)
            from c in Enumerable.Range(b + 1, n - b - 2)
            from d in Enumerable.Range(c + 1, n - c - 1)
            where nums[a] + nums[b] + nums[c] + nums[d] == target
            select new List<int> { nums[a], nums[b], nums[c], nums[d] };

        foreach (var quad in quads.Distinct(new ListComparer()))
        {
            result.Add(quad);
        }

        return result;
    }

    private class ListComparer : IEqualityComparer<List<int>>
    {
        public bool Equals(List<int> x, List<int> y)
        {
            return x.SequenceEqual(y);
        }

        public int GetHashCode(List<int> obj)
        {
            return obj.Aggregate(0, (acc, val) => acc ^ val.GetHashCode());
        }
    }
}