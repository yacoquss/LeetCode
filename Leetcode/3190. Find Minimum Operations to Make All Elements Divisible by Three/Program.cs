namespace TestApp._3190._Find_Minimum_Operations_to_Make_All_Elements_Divisible_by_Three;

public class Program
{
    public class Solution
    {
        public int MinimumOperations(int[] nums)
        {
            return nums.Count(x => x % 3 != 0);
        }
    } 
}