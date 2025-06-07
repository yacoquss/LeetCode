namespace TestApp._268._Missing_Number;

public class Program
{
    
}

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int max = nums.Max();
        for (int i = 0; i <= max+1; i++)
        {
            if (!nums.Contains(i)) return i;
        }

        return -1;
    }
}